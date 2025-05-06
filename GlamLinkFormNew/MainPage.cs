using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Windows.Forms;
using GlamLink.Shared.Models;
namespace WindowsFormsApp1
{
    public partial class MainPage : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private readonly string baseUrl = "https://localhost:44337";
        private string selectedFileNameForDeletion = null;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeClosetPage();
            ShowPage(panelCloset);
        }

        private void InitializeClosetPage()
        {
            panelCloset.Controls.Clear();
            string[] categories = { "Dresses", "Tops", "Bottoms", "Accessories", "Jackets", "Shoes" };
            int startY = 10;

            foreach (var category in categories)
            {
                var pic = new PictureBox
                {
                    Name = $"picCategory_{category}",
                    Location = new Point(10, startY),
                    Size = new Size(40, 40),
                    SizeMode = PictureBoxSizeMode.Zoom
                };

                string previewPath = Path.Combine("ClosetItems", category, "preview.jpg");
                if (File.Exists(previewPath))
                {
                    using (var img = Image.FromFile(previewPath))
                    {
                        pic.Image = new Bitmap(img);
                    }
                }
                else
                {
                    pic.BackColor = Color.LightGray;
                }

                panelCloset.Controls.Add(pic);

                var btnCategory = new Button
                {
                    Name = $"btnCategory_{category}",
                    Text = category,
                    Size = new Size(100, 40),
                    Location = new Point(60, startY)
                };
                btnCategory.Click += (s, e) => DisplayCategoryItems(category);
                panelCloset.Controls.Add(btnCategory);

                startY += 50;
            }
        }

        private async void DisplayCategoryItems(string category)
        {
            // Clear previous images and buttons
            ClearDynamicControls();

            List<Clothes> clothesItems = new List<Clothes>();
            try
            {
                var response = await client.GetAsync($"{baseUrl}/api/Closet/items?category={category}");

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    clothesItems = JsonSerializer.Deserialize<List<Clothes>>(json);  // Deserializăm într-o listă de obiecte Clothes
                }
                else
                {
                    MessageBox.Show("Failed to load item list from API.");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting items: " + ex.Message);
                return;
            }

            int x = 180, y = 10;
            int imageSize = 100;

            foreach (var item in clothesItems)
            {
                string imageUrl = $"{baseUrl}/api/Closet/image?category={category}&fileName={item.name}.jpg";
                PictureBox itemPic = new PictureBox();

                try
                {
                    var imageBytes = await client.GetByteArrayAsync(imageUrl);
                    using (var ms = new MemoryStream(imageBytes))
                    {
                        Image img = Image.FromStream(ms);
                        Image thumbnail = img.GetThumbnailImage(100, 100, () => false, IntPtr.Zero);
                        itemPic.Image = thumbnail;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to load image {item.name}: {ex.Message}");
                    continue;
                }

                itemPic.SizeMode = PictureBoxSizeMode.Zoom;
                itemPic.Location = new Point(x, y);
                itemPic.Size = new Size(imageSize, imageSize);
                itemPic.Tag = "DynamicItem";

                itemPic.Click += (s, e) =>
                {
                    SelectItemForDeletion(item.name);

                    foreach (var pic in panelCloset.Controls.OfType<PictureBox>())
                        pic.BorderStyle = BorderStyle.None;

                    itemPic.BorderStyle = BorderStyle.Fixed3D;
                };

                panelCloset.Controls.Add(itemPic);

                y += imageSize + 10;
                if (y + imageSize > panelCloset.Height)
                {
                    y = 10;
                    x += imageSize + 10;
                }
            }

            // Add / Delete buttons
            Button btnAdd = new Button
            {
                Text = $"Add {category}",
                Location = new Point(x, y + 20),
                Size = new Size(100, 30),
                Tag = "DynamicButton"
            };
            btnAdd.Click += (s, e) => AddNewItem(category);
            panelCloset.Controls.Add(btnAdd);

            Button btnDelete = new Button
            {
                Text = $"Delete {category}",
                Location = new Point(x + 110, y + 20),
                Size = new Size(100, 30),
                Tag = "DynamicButton"
            };
            btnDelete.Click += (s, e) => DeleteItem(category);
            panelCloset.Controls.Add(btnDelete);
        }


        private void ClearDynamicControls()
        {
            foreach (Control ctrl in panelCloset.Controls.OfType<PictureBox>().ToList())
            {
                if (ctrl.Tag != null && ctrl.Tag.ToString() == "DynamicItem")
                {
                    PictureBox pic = (PictureBox)ctrl;
                    pic.Image?.Dispose();
                    pic.Dispose();
                }
            }

            foreach (Control ctrl in panelCloset.Controls.OfType<Button>().ToList())
            {
                if (ctrl.Tag != null && ctrl.Tag.ToString() == "DynamicButton")
                {
                    ctrl.Dispose();
                }
            }
        }

        private void SelectItemForDeletion(string fileName)
        {
            selectedFileNameForDeletion = fileName;
            MessageBox.Show($"Selected {fileName} for deletion.");
        }

        private async void AddNewItem(string category)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select an image to upload";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    MultipartFormDataContent content = null;
                    FileStream fileStream = null;

                    try
                    {
                        content = new MultipartFormDataContent();
                        fileStream = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                        var fileContent = new StreamContent(fileStream);
                        fileContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");

                        content.Add(fileContent, "file", Path.GetFileName(ofd.FileName));
                        content.Add(new StringContent(category), "category");

                        var response = await client.PostAsync($"{baseUrl}/api/Closet/upload", content);

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Item added successfully!");
                            DisplayCategoryItems(category);
                        }
                        else
                        {
                            MessageBox.Show("Upload failed: " + response.StatusCode);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error uploading item: " + ex.Message);
                    }
                    finally
                    {
                        fileStream?.Dispose();
                        content?.Dispose();
                    }
                }
            }
        }

        private async void DeleteItem(string category)
        {
            if (string.IsNullOrEmpty(selectedFileNameForDeletion))
            {
                MessageBox.Show("Please select an item to delete first.");
                return;
            }

            string apiUrl = $"{baseUrl}/api/Closet/delete?category={category}&fileName={selectedFileNameForDeletion}";

            try
            {
                var response = await client.DeleteAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Item deleted successfully!");
                    selectedFileNameForDeletion = null;
                    DisplayCategoryItems(category);
                }
                else
                {
                    MessageBox.Show("Delete failed: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting item: " + ex.Message);
            }
        }

        private void ShowPage(Panel page)
        {
            panelCloset.Visible = false;
            panelOutfit.Visible = false;
            panelCalendar.Visible = false;
            panelComplain.Visible = false;
            panelAccount.Visible = false;

            page.Visible = true;
        }

        private void btnCloset_Click(object sender, EventArgs e) => ShowPage(panelCloset);
        private void btnOutfit_Click(object sender, EventArgs e) => ShowPage(panelOutfit);
        private void btnCalendar_Click(object sender, EventArgs e) => ShowPage(panelCalendar);
        private void btnComplain_Click(object sender, EventArgs e) => ShowPage(panelComplain);
        private void btnAccount_Click(object sender, EventArgs e) => ShowPage(panelAccount);

        public class User
        {
            public int Id { get; set; }
            public string Username { get; set; }
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }
    }
}
