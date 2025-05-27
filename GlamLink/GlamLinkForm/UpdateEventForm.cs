
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;
using WindowsFormsApp1;
using static GlamLinkForm.AddEventForm;
using static WindowsFormsApp1.MainPage;

namespace GlamLinkForm
{
    public partial class UpdateEventForm : Form
    {
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

        private static readonly HttpClient client = new HttpClient();
        private readonly int idUser;
        private readonly int idEvent;
        private EventsDTO selectedEvent;
        private List<OutfitDTO> userOutfits;

        public UpdateEventForm(int idUser, int idEvent)
        {
            InitializeComponent();
            this.idUser = idUser;
            this.idEvent = idEvent;
            comboOutfits.SelectedIndexChanged += ComboOutfits_SelectedIndexChanged;
        }

        private async void UpdateEventForm_Load(object sender, EventArgs e)
        {
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.CustomFormat = "HH:mm";
            timePicker.ShowUpDown = true;

            try
            {
                string eventsUrl = $"https://localhost:44337/api/Events/User/{idUser}";
                string outfitsUrl = $"https://localhost:44337/api/Outfits/User/{idUser}";

                var events = await client.GetFromJsonAsync<List<EventsDTO>>(eventsUrl);
                userOutfits = await client.GetFromJsonAsync<List<OutfitDTO>>(outfitsUrl);

                selectedEvent = events.FirstOrDefault(ev => ev.idEvent == idEvent);
                if (selectedEvent == null)
                {
                    MessageBox.Show("The selected event could not be found.");
                    this.Close();
                    return;
                }

                txtEventName.Text = selectedEvent.Name;
                datePicker.Value = selectedEvent.Date.Date;
                timePicker.Value = selectedEvent.Date;

                comboOutfits.DataSource = userOutfits;
                comboOutfits.DisplayMember = "Name";
                comboOutfits.ValueMember = "idOutfit";
                comboOutfits.SelectedValue = selectedEvent.idOutfit;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading event data: " + ex.Message);
            }
        }

        private async void btnSaveChanges_Click(object sender, EventArgs e)
        {
            var selectedOutfit = comboOutfits.SelectedItem as OutfitDTO;
            if (selectedOutfit == null)
            {
                MessageBox.Show("Please select an outfit.");
                return;
            }

            DateTime combinedDateTime = datePicker.Value.Date
                .AddHours(timePicker.Value.Hour)
                .AddMinutes(timePicker.Value.Minute);

            try
            {
                string eventsUrl = $"https://localhost:44337/api/Events/User/{idUser}";
                var allEvents = await client.GetFromJsonAsync<List<EventsDTO>>(eventsUrl);

                bool hasConflict = allEvents.Any(ev =>
                    ev.idEvent != selectedEvent.idEvent &&
                    ev.Date.Date == combinedDateTime.Date &&
                    ev.Date.Hour == combinedDateTime.Hour);

                if (hasConflict)
                {
                    MessageBox.Show("Another event is already scheduled at this hour.\nPlease choose a different time.", "Time Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking for conflicting events: " + ex.Message);
                return;
            }

            var updated = new EventsDTO
            {
                Name = txtEventName.Text.Trim(),
                Date = combinedDateTime,
                idOutfit = selectedOutfit.idOutfit,
                idUser = idUser,
                OutfitName = selectedOutfit.Name
            };

            try
            {
                var response = await client.PutAsJsonAsync(
                    $"https://localhost:44337/api/Events/UpdateEvent/{selectedEvent.idEvent}", updated);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Event updated successfully!");
                    this.Close();
                }
                else
                {
                    string error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Update failed: " + error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating event: " + ex.Message);
            }
        }

        private void ComboOutfits_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPreviewOutfit.Controls.Clear();

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
                        flowLayoutPreviewOutfit.Controls.Add(pic);
                    }
                }
            }
        }

        private void flowLayoutPreviewOutfit_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
    