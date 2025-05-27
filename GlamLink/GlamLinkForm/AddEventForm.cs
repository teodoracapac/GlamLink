
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlamLinkForm
{

    public partial class AddEventForm : Form
    {

        public class EventsDTO
        {
            public int idEvent { get; set; }
            public string Name { get; set; }
            public DateTime Date { get; set; }
            public int idOutfit { get; set; }
            public int idUser { get; set; }
            public string OutfitName { get; set; }
            public string Status { get; set; }
        }
        private static readonly HttpClient client = new HttpClient();
        private readonly DateTime selectedDate;
        private readonly int idUser;

        public AddEventForm(DateTime selectedDate, int idUser)
        {
            InitializeComponent();
            this.selectedDate = selectedDate;
            lblSelectedDate.Text = selectedDate.ToString("dd/MM/yyyy HH:mm");
            this.idUser = idUser;
            comboOutfits.SelectedIndexChanged += ComboOutfits_SelectedIndexChanged;
        }

        private async void AddEventForm_Load(object sender, EventArgs e)
        {
            try
            {
                string apiUrl = $"https://localhost:44337/api/outfits/user/{idUser}";
                var outfits = await client.GetFromJsonAsync<List<OutfitDTO>>(apiUrl);

                comboOutfits.DataSource = outfits;
                comboOutfits.DisplayMember = "Name";
                comboOutfits.ValueMember = "idOutfit";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load outfits:\n{ex.Message}");
            }
        }

        public class OutfitDTO
        {
            public int idOutfit { get; set; }
            public string Name { get; set; }
            public string DressImage { get; set; }
            public string TopImage { get; set; }
            public string BottomImage { get; set; }
            public string JacketImage { get; set; }
            public string ShoesImage { get; set; }
            public string AccessoriesImage { get; set; }
        }


        public class WeatherDTO
        {
            public string Date { get; set; }
            public int TemperatureC { get; set; }
            public string Summary { get; set; }
            public string IconUrl { get; set; }
        }

        private async void btnConfirmAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEventName.Text) || comboOutfits.SelectedItem == null)
            {
                MessageBox.Show("Please enter the event name and select an outfit.");
                return;
            }

            try
            {
                string checkUrl = $"https://localhost:44337/api/Events/User/{idUser}";
                var existingEvents = await client.GetFromJsonAsync<List<EventsDTO>>(checkUrl);

                bool hasConflict = existingEvents.Any(ev =>
                    ev.Date.Date == selectedDate.Date &&
                    ev.Date.Hour == selectedDate.Hour);

                if (hasConflict)
                {
                    MessageBox.Show("You already have an event scheduled at the same hour on this day.\nPlease choose a different time.", "Time Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking existing events:\n" + ex.Message);
                return;
            }

            var newEvent = new EventsDTO
            {
                Name = txtEventName.Text.Trim(),
                Date = selectedDate,
                idOutfit = (int)comboOutfits.SelectedValue,
                idUser = idUser,
                OutfitName = comboOutfits.Text
            };

            try
            {
                string apiUrl = "https://localhost:44337/api/Events/AddEvent";
                var response = await client.PostAsJsonAsync(apiUrl, newEvent);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Event added successfully!");
                    this.Close();
                }
                else
                {
                    string error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Failed to add event: {response.StatusCode}\n{error}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async Task LoadWeather()
        {
            string selectedCity = txtCity.Text.Trim();

            if (string.IsNullOrWhiteSpace(selectedCity))
            {
                MessageBox.Show("Please enter a city name.", "Missing City", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblWeatherSummary.Text = "";
                lblWeatherDate.Text = "";
                lblTemperature.Text = "";
                return;
            }

            if (selectedDate < DateTime.Today || selectedDate > DateTime.Today.AddDays(14))
            {
                lblWeatherSummary.Text = "Weather not available for this date.";
                lblWeatherDate.Text = "";
                lblTemperature.Text = "";
                return;
            }

            try
            {
                string weatherUrl = $"https://localhost:44337/api/Weather/{Uri.EscapeDataString(selectedCity)}/{selectedDate:yyyy-MM-dd}";
                var weather = await client.GetFromJsonAsync<WeatherDTO>(weatherUrl);

                if (weather == null)
                {
                    throw new Exception("Weather data was null.");
                }

                lblWeatherDate.Text = $"Forecast for {weather.Date}";
                lblTemperature.Text = $"Temperature: {weather.TemperatureC}°C";
                lblWeatherSummary.Text = $"Summary: {weather.Summary}";
                picWeatherInfo.LoadAsync(weather.IconUrl);
            }
            catch
            {
                MessageBox.Show("Could not retrieve weather for the specified city. Please check the spelling or try another location.", "Invalid Location", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblWeatherSummary.Text = "Unable to retrieve weather.";
                lblWeatherDate.Text = "";
                lblTemperature.Text = "";
                picWeatherInfo.Image = null;
            }

        }

        private async void btnCheckWeather_Click(object sender, EventArgs e)
        {
            await LoadWeather();
        }

        private void ComboOutfits_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutOutfitsPreview.Controls.Clear();

            if (comboOutfits.SelectedItem is OutfitDTO selectedOutfit)
            {
                List<string> imageUrls = new List<string>
        {
            selectedOutfit.DressImage,
            selectedOutfit.TopImage,
            selectedOutfit.BottomImage,
            selectedOutfit.JacketImage,
            selectedOutfit.ShoesImage,
            selectedOutfit.AccessoriesImage
        };

                foreach (var url in imageUrls)
                {
                    if (!string.IsNullOrWhiteSpace(url))
                    {
                        PictureBox pic = new PictureBox
                        {
                            Size = new Size(80, 100),
                            SizeMode = PictureBoxSizeMode.Zoom,
                            ImageLocation = url
                        };
                        flowLayoutOutfitsPreview.Controls.Add(pic);
                    }
                }
            }
        }

       
    }

}


