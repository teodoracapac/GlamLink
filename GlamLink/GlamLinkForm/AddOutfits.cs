using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace GlamLinkForm
{
    public partial class AddOutfits : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private int userId;

        private Dictionary<string, string> selectedImagesByCategory = new Dictionary<string, string>();
        private string selectedCategoryGlobal = null;
        private string selectedImageUrl = null;
        private PictureBox selectedPreviewPictureBox = null;
        private string selectedPreviewCategory = null;
        private PictureBox selectedClothesPictureBox = null;

        public class Clothes
        {
            public string Name { get; set; }
            public string Color { get; set; }
            public string Season { get; set; }
            public string ImageUrl { get; set; }
        }

        public class Outfits
        {
            public int idOutfit { get; set; }
            public string Name { get; set; }
            public DateTime Creation_Date { get; set; }
            public string DressImage { get; set; }
            public string TopImage { get; set; }
            public string BottomImage { get; set; }
            public string JacketImage { get; set; }
            public string ShoesImage { get; set; }
            public string AccessoriesImage { get; set; }
            public int idUser { get; set; }
        }

        public AddOutfits(int userId)
        {
            InitializeComponent();
            this.userId = userId;

            btnDresses.Click += (s, e) => LoadCategoryClothes("Dresses");
            btnTops.Click += (s, e) => LoadCategoryClothes("Tops");
            btnBottoms.Click += (s, e) => LoadCategoryClothes("Bottoms");
            btnJackets.Click += (s, e) => LoadCategoryClothes("Jackets");
            btnShoes.Click += (s, e) => LoadCategoryClothes("Shoes");
            btnAccessories.Click += (s, e) => LoadCategoryClothes("Accessories");
            btnAddItem.Click += btnAddItem_Click;
            btnDeleteItem.Click += btnDeleteItem_Click;
        }

        private async void LoadCategoryClothes(string category)
        {
            try
            {
                string url = $"https://localhost:44337/api/closet/items?category={category}&userId={userId}";
                var response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                var json = await response.Content.ReadAsStringAsync();
                var items = JsonConvert.DeserializeObject<List<Clothes>>(json);

                selectedCategoryGlobal = category;
                flowLayoutClothes.Controls.Clear();

                foreach (var item in items)
                {
                    var pic = new PictureBox
                    {
                        Width = 100,
                        Height = 100,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        ImageLocation = item.ImageUrl,
                        Tag = item.ImageUrl,
                        Cursor = Cursors.Hand
                    };

                    pic.Click += (s, e) =>
                    {
                        if (selectedClothesPictureBox != null)
                            selectedClothesPictureBox.BorderStyle = BorderStyle.FixedSingle;

                        // Highlight newly selected image
                        selectedClothesPictureBox = (PictureBox)s;
                        selectedClothesPictureBox.BorderStyle = BorderStyle.Fixed3D;

                        selectedImageUrl = (string)selectedClothesPictureBox.Tag;
                        btnAddItem.Visible = true;
                    };

                    flowLayoutClothes.Controls.Add(pic);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading category: " + ex.Message);
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(selectedCategoryGlobal) || string.IsNullOrWhiteSpace(selectedImageUrl))
            {
                MessageBox.Show("Please select an item first.");
                return;
            }

            // Store the selected image path
            selectedImagesByCategory[selectedCategoryGlobal] = selectedImageUrl;

            // Refresh the right-side preview
            RefreshSelectedImagesPreview();

            // Clear selection
            selectedCategoryGlobal = null;
            selectedImageUrl = null;
            btnAddItem.Visible = false;
            flowLayoutClothes.Controls.Clear();
        }

        private void RefreshSelectedImagesPreview()
        {
            flowPanelSelectedImages.Controls.Clear();
            flowPanelSelectedImages.AutoScroll = true;
            selectedPreviewCategory = null;
            selectedPreviewPictureBox = null;

            foreach (var kvp in selectedImagesByCategory)
            {
                string category = kvp.Key;
                string imageUrl = kvp.Value;

                var pic = new PictureBox
                {
                    Width = 100,
                    Height = 100,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    ImageLocation = imageUrl,
                    Tag = category,
                    Cursor = Cursors.Hand,
                    BorderStyle = BorderStyle.FixedSingle
                };

                pic.Click += (s, e) =>
                {
                    // Deselect previous
                    foreach (var container in flowPanelSelectedImages.Controls.OfType<FlowLayoutPanel>())
                    {
                        foreach (var img in container.Controls.OfType<PictureBox>())
                            img.BorderStyle = BorderStyle.FixedSingle;
                    }

                    pic.BorderStyle = BorderStyle.Fixed3D;
                    selectedPreviewPictureBox = pic;
                    selectedPreviewCategory = (string)pic.Tag;
                };

                var previewPanel = new FlowLayoutPanel
                {
                    Width = 110,
                    Height = 110,
                    FlowDirection = FlowDirection.TopDown
                };

                previewPanel.Controls.Add(pic);
                flowPanelSelectedImages.Controls.Add(previewPanel);
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(selectedPreviewCategory) || selectedPreviewPictureBox == null)
            {
                MessageBox.Show("Please select an image in the preview to delete.");
                return;
            }

            // Remove from dictionary
            selectedImagesByCategory.Remove(selectedPreviewCategory);

            // Refresh preview panel
            RefreshSelectedImagesPreview();
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter an outfit name.");
                return;
            }

            if (!selectedImagesByCategory.Any())
            {
                MessageBox.Show("Select at least one item for the outfit.");
                return;
            }

            var outfit = new Outfits
            {
                Name = txtName.Text.Trim(),
                Creation_Date = DateTime.Now,
                DressImage = selectedImagesByCategory.TryGetValue("Dresses", out var d) ? d : null,
                TopImage = selectedImagesByCategory.TryGetValue("Tops", out var t) ? t : null,
                BottomImage = selectedImagesByCategory.TryGetValue("Bottoms", out var b) ? b : null,
                JacketImage = selectedImagesByCategory.TryGetValue("Jackets", out var j) ? j : null,
                ShoesImage = selectedImagesByCategory.TryGetValue("Shoes", out var s) ? s : null,
                AccessoriesImage = selectedImagesByCategory.TryGetValue("Accessories", out var a) ? a : null,
                idUser = userId
            };

            var jsonContent = new StringContent(JsonConvert.SerializeObject(outfit), Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://localhost:44337/api/outfits/add", jsonContent);
            var result = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Outfit added successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to add outfit:\n" + result);
            }
        }

    }
}
