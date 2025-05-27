using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlamLinkForm
{
    public partial class AddClothesForm : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private string selectedFilePath = string.Empty;
        private int idUser;

        public AddClothesForm(int idUser)
        {
            InitializeComponent();
            this.idUser = idUser;
        }

        private void btnBrowse_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png",
                Title = "Select a clothing image"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;
                picPreview.Image = Image.FromFile(selectedFilePath); 
            }
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
            string.IsNullOrWhiteSpace(cbCategory.Text) ||
            string.IsNullOrWhiteSpace(txtColor.Text) ||
            string.IsNullOrWhiteSpace(cbSeason.Text) ||
            string.IsNullOrWhiteSpace(selectedFilePath))
            {
                MessageBox.Show("Please fill in all fields and select an image.");
                return;
            }

            using (var formData = new MultipartFormDataContent())
            {
                formData.Add(new StringContent(txtName.Text), "Name");
                formData.Add(new StringContent(cbCategory.Text), "Category");
                formData.Add(new StringContent(txtColor.Text), "Color");
                formData.Add(new StringContent(cbSeason.Text), "Season");

                formData.Add(new StringContent(idUser.ToString()), "idUser");

                var fileStream = File.OpenRead(selectedFilePath);
                var fileContent = new StreamContent(fileStream);
                fileContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/jpeg");
                formData.Add(fileContent, "File", Path.GetFileName(selectedFilePath));

                try
                {
                    string apiUrl = "https://localhost:44337/api/closet/upload"; 
                    var response = await client.PostAsync(apiUrl, formData);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Clothing item added successfully.");
                        this.Close();
                    }
                    else
                    {
                        string error = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Upload failed: {response.StatusCode}\n{error}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
    }
}
