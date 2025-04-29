using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private string selectedItemPath = string.Empty;
        private PictureBox selectedPictureBox = null;
        

        public Form1()
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


        private Image LoadImageWithoutLocking(string path)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(path);
                if (fileInfo.Length == 0)
                {
                    MessageBox.Show($"File is empty: {path}");
                    return null;
                }

                byte[] imageData = File.ReadAllBytes(path);
                using (var ms = new MemoryStream(imageData))
                {
                    return Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load image: {path}\nError: {ex.Message}");
                return null;
            }
        }






        private void DisplayCategoryItems(string category)
        {
            // Clear old PictureBoxes (Dynamic Items)
            foreach (Control ctrl in panelCloset.Controls.OfType<PictureBox>().ToList())
            {
                if (ctrl.Tag != null && ctrl.Tag.ToString() == "DynamicItem")
                {
                    if (ctrl is PictureBox pic)
                    {
                        pic.Image?.Dispose();
                        pic.Image = null;
                    }
                    panelCloset.Controls.Remove(ctrl);
                    ctrl.Dispose();
                }
            }

            // Clear old dynamic Buttons
            foreach (Control ctrl in panelCloset.Controls.OfType<Button>().ToList())
            {
                if (ctrl.Tag != null && ctrl.Tag.ToString() == "DynamicButton")
                {
                    panelCloset.Controls.Remove(ctrl);
                    ctrl.Dispose();
                }
            }

            string folderPath = Path.Combine("ClosetItems", category);
            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show($"Folder not found: {folderPath}");
                return;
            }

            string[] imageFiles = Directory
                .GetFiles(folderPath, "*.jpg")
                .Where(file => !file.EndsWith("preview.jpg", StringComparison.OrdinalIgnoreCase))
                .ToArray();

            int x = 180, y = 10;
            int imageSize = 100;

            foreach (var file in imageFiles)
            {
                PictureBox itemPic = new PictureBox();

                Image imgTemp = LoadImageWithoutLocking(file);
                if (imgTemp == null)
                    continue; // skip this file

                Image thumbnail = imgTemp.GetThumbnailImage(100, 100, () => false, IntPtr.Zero);
                imgTemp.Dispose(); // Free memory

                itemPic.Image = thumbnail;
                itemPic.SizeMode = PictureBoxSizeMode.Zoom;
                itemPic.Location = new Point(x, y);
                itemPic.Size = new Size(imageSize, imageSize);
                itemPic.Tag = file;
                itemPic.Click += (s, e) => SelectItemForDeletion(file);
                itemPic.Tag = "DynamicItem";
                panelCloset.Controls.Add(itemPic);

                y += imageSize + 10;
                if (y + imageSize > panelCloset.Height)
                {
                    y = 10;
                    x += imageSize + 10;
                }
            


        }

        // Add Buttons (Add and Delete)
        Button btnAdd = new Button();
            btnAdd.Text = $"Add {category}";
            btnAdd.Location = new Point(x, y + 20);
            btnAdd.Size = new Size(100, 30);
            btnAdd.Tag = "DynamicButton";
            btnAdd.Click += (s, e) => AddNewItem(category);
            panelCloset.Controls.Add(btnAdd);

            Button btnDelete = new Button();
            btnDelete.Text = $"Delete {category}";
            btnDelete.Location = new Point(x + 110, y + 20);
            btnDelete.Size = new Size(100, 30);
            btnDelete.Tag = "DynamicButton";
            btnDelete.Click += (s, e) => DeleteItem();
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


        private void SelectItemForDeletion(PictureBox pic)
        {
            selectedItemPath = pic.Tag?.ToString();
            selectedPictureBox = pic;

            if (!string.IsNullOrEmpty(selectedItemPath))
            {
                MessageBox.Show($"Selected item: {Path.GetFileName(selectedItemPath)}");
            }
        }


        private void AddNewItem(string category)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png",
                Title = $"Select a {category} Image"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openFileDialog.FileName;
                string folderPath = Path.Combine("ClosetItems", category);

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string destinationFile = Path.Combine(folderPath, Path.GetFileName(selectedFile));

                try
                {
                    File.Copy(selectedFile, destinationFile, true);

                    MessageBox.Show($"{category} added successfully!");

                    DisplayCategoryItems(category);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while adding the {category}: {ex.Message}");
                }
            }
        }



        private void DeleteItem()
        {
            if (string.IsNullOrEmpty(selectedItemPath))
            {
                MessageBox.Show("Please select an item to delete first.");
                return;
            }

            try
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to delete {Path.GetFileName(selectedItemPath)}?", "Confirm Deletion", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    if (File.Exists(selectedItemPath))
                    {
                        File.Delete(selectedItemPath);
                    }

                    MessageBox.Show($"Item {Path.GetFileName(selectedItemPath)} deleted successfully.");

                    // Refresh
                    string category = Path.GetDirectoryName(selectedItemPath).Split(Path.DirectorySeparatorChar).Last();
                    selectedItemPath = string.Empty; // Reset
                    DisplayCategoryItems(category);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the item: {ex.Message}");
            }
        }




        private void SelectItemForDeletion(string filePath)
        {
            selectedItemPath = filePath;
            MessageBox.Show($"Selected item: {Path.GetFileName(filePath)}");
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

        private async void btnLoadUsers_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:7170/api/users"; // Adjust if needed
            try
            {
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var users = JsonSerializer.Deserialize<List<User>>(jsonResponse);

                    // You could bind 'users' to a grid or list here
                }
                else
                {
                    MessageBox.Show("Error connecting to API: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception occurred: " + ex.Message);
            }
        }

        private void btnCloset_Click(object sender, EventArgs e)
        {
            ShowPage(panelCloset);
        }

        private void btnOutfit_Click(object sender, EventArgs e)
        {
            ShowPage(panelOutfit);
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            ShowPage(panelCalendar);
        }

        private void btnComplain_Click(object sender, EventArgs e)
        {
            ShowPage(panelComplain);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            ShowPage(panelAccount);
        }

        private void btnDresses_Click(object sender, EventArgs e)
        {
            DisplayCategoryItems("Dresses");
        }

        private void btnBottoms_Click(object sender, EventArgs e)
        {
            DisplayCategoryItems("Bottoms");
        }

        private void btnJackets_Click(object sender, EventArgs e)
        {
            DisplayCategoryItems("Jackets");
        }

        public class User
        {
            public int Id { get; set; }
            public string Username { get; set; }
        }
    }
}
