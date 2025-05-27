using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using WindowsFormsApp1;
using static WindowsFormsApp1.MainPage;
namespace GlamLinkForm
{
    public partial class UpdateOutfitForm : Form
    {
        private Outfits selectedOutfit;
        private static readonly HttpClient client = new HttpClient();
        private PictureBox selectedPreviewImage = null;
        private string selectedPreviewCategory = null;
        private PictureBox selectedPreviewPictureBox = null;
        private int userId;

        private string selectedCategoryGlobal = null;
        private string selectedImageUrl = null;
        private PictureBox selectedClothesPictureBox = null;

        public class Clothes
        {
            public string Name { get; set; }
            public string Color { get; set; }
            public string Season { get; set; }
            public string ImageUrl { get; set; }
        }

        public UpdateOutfitForm(Outfits outfit, int userId)
        {
            InitializeComponent();

            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
            System.Net.ServicePointManager.ServerCertificateValidationCallback +=
                (sender, cert, chain, sslPolicyErrors) => true;

            selectedOutfit = outfit;
            this.userId = userId;
            LoadOutfitDetails();
            this.userId = userId;
        }

        private void LoadOutfitDetails()
        {
            if (selectedOutfit == null) return;
            txtOutfitName.Text = selectedOutfit.Name;
            panelImages.Controls.Clear();
            AddImageBox("DressImage", selectedOutfit.DressImage);
            AddImageBox("TopImage", selectedOutfit.TopImage);
            AddImageBox("BottomImage", selectedOutfit.BottomImage);
            AddImageBox("JacketImage", selectedOutfit.JacketImage);
            AddImageBox("ShoesImage", selectedOutfit.ShoesImage);
            AddImageBox("AccessoriesImage", selectedOutfit.AccessoriesImage);
        }

        private void AddImageBox(string category, string imageUrl)
        {
            if (string.IsNullOrWhiteSpace(imageUrl)) return;

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
                foreach (var panel in panelImages.Controls.OfType<FlowLayoutPanel>())
                {
                    foreach (var p in panel.Controls.OfType<PictureBox>())
                        p.BorderStyle = BorderStyle.FixedSingle;
                }

                // Select new
                pic.BorderStyle = BorderStyle.Fixed3D;
                selectedPreviewCategory = (string)pic.Tag;
                selectedPreviewPictureBox = pic;
            };

            var container = new FlowLayoutPanel
            {
                Width = 110,
                Height = 110,
                FlowDirection = FlowDirection.TopDown
            };

            container.Controls.Add(pic);
            panelImages.Controls.Add(container);
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(selectedPreviewCategory) || selectedPreviewPictureBox == null)
            {
                MessageBox.Show("Please select an item to delete.");
                return;
            }

            var containerToRemove = panelImages.Controls
                .OfType<FlowLayoutPanel>()
                .FirstOrDefault(fp => fp.Controls.Contains(selectedPreviewPictureBox));

            if (containerToRemove != null)
                panelImages.Controls.Remove(containerToRemove);

            switch (selectedPreviewCategory)
            {
                case "DressImage": selectedOutfit.DressImage = null; break;
                case "TopImage": selectedOutfit.TopImage = null; break;
                case "BottomImage": selectedOutfit.BottomImage = null; break;
                case "JacketImage": selectedOutfit.JacketImage = null; break;
                case "ShoesImage": selectedOutfit.ShoesImage = null; break;
                case "AccessoriesImage": selectedOutfit.AccessoriesImage = null; break;
                default: MessageBox.Show("Unknown category."); break;
            }

            // Reset selection
            selectedPreviewCategory = null;
            selectedPreviewPictureBox = null;
        }

        private async Task LoadCategoryClothes(string category)
        {
            try
            {
                string url = $"https://localhost:44337/api/closet/items?category={category}&userId={userId}";

                var response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();
                var items = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Clothes>>(json);

                flowLayoutClothes.Controls.Clear();

                foreach (var item in items)
                {
                    var picBox = new PictureBox
                    {
                        Width = 100,
                        Height = 100,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        ImageLocation = item.ImageUrl,
                        Tag = item.ImageUrl
                    };

                    picBox.Click += (s, e) =>
                    {
                        // Deselect previous
                        if (selectedClothesPictureBox != null)
                            selectedClothesPictureBox.BorderStyle = BorderStyle.FixedSingle;

                        // Select new
                        selectedClothesPictureBox = (PictureBox)s;
                        selectedClothesPictureBox.BorderStyle = BorderStyle.Fixed3D;

                        selectedImageUrl = (string)selectedClothesPictureBox.Tag;
                        selectedCategoryGlobal = category;
                        btnAddItem.Visible = true;
                    };


                    flowLayoutClothes.Controls.Add(picBox);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading " + category + " images: " + ex.Message);
            }
        }

        private void SetSelectedImage(string category, string imageUrl)
        {
            switch (category)
            {
                case "Dresses": selectedOutfit.DressImage = imageUrl; break;
                case "Tops": selectedOutfit.TopImage = imageUrl; break;
                case "Bottoms": selectedOutfit.BottomImage = imageUrl; break;
                case "Jackets": selectedOutfit.JacketImage = imageUrl; break;
                case "Shoes": selectedOutfit.ShoesImage = imageUrl; break;
                case "Accessories": selectedOutfit.AccessoriesImage = imageUrl; break;
            }
        }

        private async void btnSaveChanges_Click(object sender, EventArgs e)
        {

            try
            {
                // Update outfit name from textbox
                selectedOutfit.Name = txtOutfitName.Text;

                // Serialize the updated outfit
                var json = JsonConvert.SerializeObject(selectedOutfit);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PutAsync($"https://localhost:44337/api/outfits/update/{selectedOutfit.idOutfit}", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Outfit updated successfully.");
                    this.Close(); 
                }
                else
                {
                    var error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Update failed: " + error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnChangeName_Click(object sender, EventArgs e)
        {
            selectedOutfit.Name = txtOutfitName.Text;
            MessageBox.Show("Name updated locally. Click Save to confirm.");
        }

        private void btnDresses_Click(object sender, EventArgs e)
        {
            LoadCategoryClothes("Dresses");
        }

        private void btnTops_Click(object sender, EventArgs e)
        {
            LoadCategoryClothes("Tops");
        }

        private void btnBottoms_Click(object sender, EventArgs e)
        {
            LoadCategoryClothes("Bottoms");
        }

        private void btnJackets_Click(object sender, EventArgs e)
        {
            LoadCategoryClothes("Jackets");
        }

        private void btnShoes_Click(object sender, EventArgs e)
        {
            LoadCategoryClothes("Shoes");
        }

        private void btnAccessories_Click(object sender, EventArgs e)
        {
            LoadCategoryClothes("Accessories");
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(selectedImageUrl) || string.IsNullOrWhiteSpace(selectedCategoryGlobal))
            {
                MessageBox.Show("Please select an item first.");
                return;
            }

            // Update outfit model
            SetSelectedImage(selectedCategoryGlobal, selectedImageUrl);

            // Update preview UI
            AddImageBox($"{selectedCategoryGlobal.TrimEnd('s')}Image", selectedImageUrl); // DressImage, TopImage etc.

            // Reset selection
            selectedImageUrl = null;
            selectedCategoryGlobal = null;
            btnAddItem.Visible = false;
            flowLayoutClothes.Controls.Clear();
        }

    }
}
