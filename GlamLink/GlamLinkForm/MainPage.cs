using GlamLinkForm;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static WindowsFormsApp1.MainPage;
using static WindowsFormsApp1.MainPage.Outfits;

namespace WindowsFormsApp1
{
    public partial class MainPage : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private string selectedItemPath = string.Empty;
        private PictureBox selectedPictureBox = null;
        private ClothesDTO selectedItem = null;
        private Dictionary<string, int> outfitIdMap = new Dictionary<string, int>();


        public int LoggedInUserId { get; set; }

        public MainPage(int userId)
        {
            InitializeComponent();
            LoggedInUserId = userId;
            LoadOutfits();
            this.Load += (s, e) => LoadOutfits();
          
            listBoxOutfits.SelectedIndexChanged += listBoxOutfits_SelectedIndexChanged;
            tabControl1.DrawItem += new DrawItemEventHandler(this.tabControl1_DrawItem);

            //For the design in the Account tab, verify credentials part
            labelNewUsername.Enabled = false;
            textBoxNewUsername.Enabled = false; 
            textBoxNewUsername.BackColor = Color.LightGray;

            labelNewPassword.Enabled = false;
            textBoxNewPassword.Enabled = false;
            textBoxNewPassword.BackColor = Color.LightGray;

            //For the design in the Account tab for the users

            btnUpdateAccount.Enabled = false;
            btnUpdateAccount.BackColor = Color.LightGray;
            btnUpdateAccount.ForeColor = Color.Gray;
            btnUpdateAccount.UseVisualStyleBackColor = false;


        }

        private async void btnLoadUsers_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:7170/api/users";
            try
            {
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var users = System.Text.Json.JsonSerializer.Deserialize<List<User>>(jsonResponse);

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

        public class User
        {
            public int Id { get; set; }
            public string Username { get; set; }
        }

       
        public class ComplaintDTO
        {
            public int idUser { get; set; }
            public string Subject { get; set; }
            public string Text { get; set; }
            public string Domain { get; set; }
        }
        public class ClothesDTO
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
            public string DressImage { get; set; } = null;
            public string TopImage { get; set; } = null;
            public string BottomImage { get; set; } = null;
            public string JacketImage { get; set; } = null;
            public string ShoesImage { get; set; } = null;
            public string AccessoriesImage { get; set; } = null;
            public override string ToString() => Name;
            public int idUser { get; set; }

            public class CheckLinksResponse
            {
                public bool IsLinkedToOutfit { get; set; }
                public bool IsLinkedToEvent { get; set; }
            }
        }

        // Tab Closet - afisare haine + adaugare haine (Mara)

        // ADD CLOTHES
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddClothesForm addClothesForm = new AddClothesForm(LoggedInUserId);
            addClothesForm.ShowDialog();
            this.Show();
        }

        private async Task LoadClothingItemsByCategory(string category)
        {
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
            System.Net.ServicePointManager.ServerCertificateValidationCallback +=
                (_, cert, chain, sslPolicyErrors) => true;

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync($"https://localhost:44337/api/Closet/items?category={category}&userId={LoggedInUserId}");

                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        var items = JsonConvert.DeserializeObject<List<ClothesDTO>>(json);

                        flowLayoutPanelClothes.Controls.Clear();
                        selectedItem = null;
                        selectedPictureBox = null;

                        foreach (var item in items)
                        {
                            PictureBox pic = new PictureBox
                            {
                                Width = 100,
                                Height = 100,
                                SizeMode = PictureBoxSizeMode.StretchImage,
                                ImageLocation = item.ImageUrl,
                                Cursor = Cursors.Hand,
                                Tag = item 
                            };

                            pic.Click += (s, e) =>
                            {
                           
                                if (selectedPictureBox != null)
                                    selectedPictureBox.BorderStyle = BorderStyle.FixedSingle;

                            
                                selectedPictureBox = (PictureBox)s;
                                selectedPictureBox.BorderStyle = BorderStyle.Fixed3D;

                                selectedItem = (ClothesDTO)selectedPictureBox.Tag;
                            };

                            Label nameLabel = new Label
                            {
                                Text = item.Name,
                                AutoSize = true,
                                TextAlign = ContentAlignment.MiddleCenter
                            };

                            FlowLayoutPanel itemPanel = new FlowLayoutPanel
                            {
                                Width = 110,
                                Height = 140,
                                FlowDirection = FlowDirection.TopDown
                            };

                            itemPanel.Controls.Add(pic);
                            itemPanel.Controls.Add(nameLabel);

                            flowLayoutPanelClothes.Controls.Add(itemPanel);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to retrieve items for category: " + category);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private async void btnCategory_Dresses_Click(object sender, EventArgs e)
        {
            await LoadClothingItemsByCategory("Dresses");
        }

        private async void btnCategory_Bottoms_Click(object sender, EventArgs e)
        {
            await LoadClothingItemsByCategory("Bottoms");
        }

        private async void btnCategory_Tops_Click(object sender, EventArgs e)
        {
            await LoadClothingItemsByCategory("Tops");
        }

        private async void btnCategory_Acc_Click(object sender, EventArgs e)
        {
            await LoadClothingItemsByCategory("Accessories");
        }

        private async void btnCategory_Jackets_Click(object sender, EventArgs e)
        {
            await LoadClothingItemsByCategory("Jackets");
        }

        private async void btnCategory_Shoes_Click(object sender, EventArgs e)
        {
            await LoadClothingItemsByCategory("Shoes");
        }

        // DELETE CLOTHES
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedItem == null)
            {
                MessageBox.Show("Please select an item to delete.");
                return;
            }

            string checkUrl = $"https://localhost:44337/api/Closet/check-links?name={Uri.EscapeDataString(selectedItem.Name)}&userId={LoggedInUserId}";

            try
            {
                var checkResponse = await client.GetAsync(checkUrl);
                checkResponse.EnsureSuccessStatusCode();
                var checkJson = await checkResponse.Content.ReadAsStringAsync();
                Console.WriteLine("checkJson: " + checkJson);

                var checkResult = JsonConvert.DeserializeObject<CheckLinksResponse>(checkJson);

                Console.WriteLine($"Outfit? {checkResult.IsLinkedToOutfit}, Event? {checkResult.IsLinkedToEvent}");

                string warningMessage = "Are you sure you want to delete this clothing item?";

                if (checkResult.IsLinkedToEvent)
                {
                    warningMessage = "This item is part of an outfit used in an event.\n" +
                                     "Deleting it will also delete the outfit and the event.\n\n" +
                                     "Are you sure you want to continue?";
                }
                else if (checkResult.IsLinkedToOutfit)
                {
                    warningMessage = "This item is part of an outfit.\n" +
                                     "Deleting it will also delete the outfit.\n\n" +
                                     "Are you sure you want to continue?";
                }

                var confirm = MessageBox.Show(warningMessage, "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm != DialogResult.Yes)
                    return;

                var deleteUrl = $"https://localhost:44337/api/Closet/delete?name={Uri.EscapeDataString(selectedItem.Name)}&userId={LoggedInUserId}";
                var response = await client.DeleteAsync(deleteUrl);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Item deleted successfully.");
                    flowLayoutPanelClothes.Controls.Remove(selectedPictureBox);
                    selectedItem = null;
                    selectedPictureBox = null;
                }
                else
                {
                    var error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Failed to delete: " + error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // OUTFITS TAB
        // ADD OUTFIT 
        private void btnAddOutfit_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddOutfits form = new AddOutfits(LoggedInUserId);
            form.ShowDialog();
            this.Show();
        }
        // UPDATE OUTFIT
        private async void btnEditOutfit_Click(object sender, EventArgs e)
        {
            if (listBoxOutfits.SelectedItem is string selectedOutfitName &&
            outfitIdMap.TryGetValue(selectedOutfitName, out int outfitId))
            {
                try
                {
                    var response = await client.GetAsync($"https://localhost:44337/api/outfits/{outfitId}");
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        var outfit = JsonConvert.DeserializeObject<Outfits>(json);

                        var updateForm = new UpdateOutfitForm(outfit, LoggedInUserId);
                        updateForm.ShowDialog();
                        LoadOutfits(); // Refresh list after update
                    }
                    else
                    {
                        MessageBox.Show("Failed to load selected outfit from the server.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select an outfit to update.");
            }
        }
        // DELETE OUTFIT
        private async void btnDeleteOutfit_Click(object sender, EventArgs e)
        {
            if (listBoxOutfits.SelectedItem is string selectedOutfitName && outfitIdMap.TryGetValue(selectedOutfitName, out int outfitId))
            {
                try
                {
                    // Check if the outfit is linked to any event
                    string checkUrl = $"https://localhost:44337/api/outfits/check-links/{outfitId}";
                    var checkResponse = await client.GetAsync(checkUrl);
                    checkResponse.EnsureSuccessStatusCode();

                    var checkJson = await checkResponse.Content.ReadAsStringAsync();
                    var checkResult = JsonConvert.DeserializeObject<CheckLinksResponse>(checkJson);

                    // Default warning message
                    string warningMessage = $"Are you sure you want to delete the outfit: {selectedOutfitName}?";

                    if (checkResult != null && checkResult.IsLinkedToEvent)
                    {
                        warningMessage = "This outfit is used in an event.\n" +
                                         "Deleting it will also delete the event.\n\n" +
                                         "Are you sure you want to continue?";
                    }

                    // Confirm with user
                    var confirm = MessageBox.Show(
                        warningMessage,
                        "Confirm Deletion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (confirm != DialogResult.Yes)
                        return;

                    // Proceed with deletion
                    string deleteUrl = $"https://localhost:44337/api/outfits/delete/{outfitId}";
                    var response = await client.DeleteAsync(deleteUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Outfit deleted successfully.");
                        LoadOutfits(); // refresh list
                        panelOutfitPreview.Controls.Clear(); // clear preview
                    }
                    else
                    {
                        string error = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Failed to delete outfit: " + error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select an outfit to delete.");
            }
        }
        private void btnRefreshOutfits_Click(object sender, EventArgs e)
        {
            LoadOutfits();
        }

        private async void LoadOutfits()
        {
            try
            {
                var response = await client.GetAsync($"https://localhost:44337/api/outfits/user/{LoggedInUserId}");
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();
                var outfits = JsonConvert.DeserializeObject<List<Outfits>>(json);

                outfitIdMap.Clear();
                listBoxOutfits.Items.Clear();

                foreach (var outfit in outfits)
                {
                    listBoxOutfits.Items.Add(outfit.Name); // Show name only
                    outfitIdMap[outfit.Name] = outfit.idOutfit; // Track id for delete/edit
                }

                if (listBoxOutfits.Items.Count == 0)
                {
                    panelOutfitPreview.Controls.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading outfits: " + ex.Message);
            }
        }

        private async void listBoxOutfits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxOutfits.SelectedItem is string selectedOutfitName && outfitIdMap.TryGetValue(selectedOutfitName, out int outfitId))
            {
                try
                {
                    var response = await client.GetAsync($"https://localhost:44337/api/outfits/{outfitId}");
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        var outfit = JsonConvert.DeserializeObject<Outfits>(json);
                        panelOutfitPreview.Controls.Clear();
                        AddImageToPanel(panelOutfitPreview, outfit.DressImage);
                        AddImageToPanel(panelOutfitPreview, outfit.TopImage);
                        AddImageToPanel(panelOutfitPreview, outfit.BottomImage);
                        AddImageToPanel(panelOutfitPreview, outfit.JacketImage);
                        AddImageToPanel(panelOutfitPreview, outfit.ShoesImage);
                        AddImageToPanel(panelOutfitPreview, outfit.AccessoriesImage);
                    }
                    else
                    {
                        panelOutfitPreview.Controls.Clear(); // clear if not found
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load outfit details: " + ex.Message);
                    panelOutfitPreview.Controls.Clear();
                }
            }
        }

        private void AddImageToPanel(Control panel, string imageUrl)
        {

            if (!string.IsNullOrWhiteSpace(imageUrl))
            {
                PictureBox pic = new PictureBox
                {
                    Width = 100,
                    Height = 100,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    ImageLocation = imageUrl
                };
                panel.Controls.Add(pic);
            }
        }



        // EVENTS TAB
        // ADD EVENT
        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            int userid = LoggedInUserId;
            DateTime selectedDate = calendarEvent.SelectionStart.Date;
            TimeSpan selectedTime = timePickerEvent.Value.TimeOfDay;
            DateTime fullDateTime = selectedDate.Add(selectedTime);
            var addEventForm = new AddEventForm(fullDateTime, userid);
            addEventForm.ShowDialog();
        }
        // DELETE EVENT
        private async void btnDelEvent_Click(object sender, EventArgs e)
        {
            if (listBoxEvents.SelectedIndex >= 0 && eventsForSelectedDate != null && listBoxEvents.SelectedIndex < eventsForSelectedDate.Count)
            {
                var selectedEvent = eventsForSelectedDate[listBoxEvents.SelectedIndex];

                var confirm = MessageBox.Show(
                    $"Are you sure you want to delete the event: {selectedEvent.Name}?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        var deleteUrl = $"https://localhost:44337/api/Events/DeleteEvent?id={selectedEvent.idEvent}";
                        var response = await client.DeleteAsync(deleteUrl);

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Event deleted successfully.");

                            // Optionally refresh events and UI
                            await ShowEventInfoForDate(calendarEvent.SelectionStart);
                            HighlightEventDays();
                        }
                        else
                        {
                            string error = await response.Content.ReadAsStringAsync();
                            MessageBox.Show($"Failed to delete event: {response.StatusCode}\n{error}");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error while deleting event: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an event from the list to delete.");
            }
        }
        // UPDATE EVENT
        private void btnUpdateEvent_Click(object sender, EventArgs e)
        {
            if (listBoxEvents.SelectedIndex >= 0 && listBoxEvents.SelectedIndex < eventsForSelectedDate.Count)
            {
                var selectedEvent = eventsForSelectedDate[listBoxEvents.SelectedIndex];
                var form = new UpdateEventForm(LoggedInUserId, selectedEvent.idEvent);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select an event from the list to update.");
            }
        }
        

        // function to bold dates with events
        private async void HighlightEventDays()
        {
            try
            {
                string apiUrl = $"https://localhost:44337/api/Events/User/{this.LoggedInUserId}";
                var events = await client.GetFromJsonAsync<List<AddEventForm.EventsDTO>>(apiUrl);

                var eventDates = events
                    .Select(e => e.Date.Date)
                    .Distinct()
                    .ToArray();

                calendarEvent.BoldedDates = eventDates;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load event highlights: " + ex.Message);
            }
        }

        private void ShowOutfitImages(Outfits outfit)
        {
            flowPanelOutfit_Event.Controls.Clear();

            AddImageToPanel(flowPanelOutfit_Event, outfit.DressImage);
            AddImageToPanel(flowPanelOutfit_Event, outfit.TopImage);
            AddImageToPanel(flowPanelOutfit_Event, outfit.BottomImage);
            AddImageToPanel(flowPanelOutfit_Event, outfit.JacketImage);
            AddImageToPanel(flowPanelOutfit_Event, outfit.ShoesImage);
            AddImageToPanel(flowPanelOutfit_Event, outfit.AccessoriesImage);
        }

        private void btnLoadEvents_Click(object sender, EventArgs e)
        {
            HighlightEventDays();
        }

        private async void calendarEvent_DateSelected(object sender, DateRangeEventArgs e)
        {
            await ShowEventInfoForDate(e.Start.Date);
        }

        private List<AddEventForm.EventsDTO> eventsForSelectedDate = new List<AddEventForm.EventsDTO>();

        private async Task ShowEventInfoForDate(DateTime date)
        {
            try
            {
                string url = $"https://localhost:44337/api/Events/User/{this.LoggedInUserId}";
                var events = await client.GetFromJsonAsync<List<AddEventForm.EventsDTO>>(url);

                eventsForSelectedDate = events
                    .Where(ev => ev.Date.Date == date.Date)
                    .ToList();

                listBoxEvents.Items.Clear();
                flowPanelOutfit_Event.Controls.Clear();

                if (eventsForSelectedDate.Any())
                {
                    foreach (var ev in eventsForSelectedDate)
                    {
                        listBoxEvents.Items.Add($"{ev.Name} at {ev.Date:HH:mm}");
                    }

                    lblEventInfo.Text = "Select an event from the list.";
                }
                else
                {
                    lblEventInfo.Text = "No events on this day.";
                }
            }
            catch (Exception ex)
            {
                lblEventInfo.Text = "Error retrieving event info.";
                MessageBox.Show("Failed to load event details:\n" + ex.Message);

            }
        }


        private async void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEvents.SelectedIndex >= 0 && listBoxEvents.SelectedIndex < eventsForSelectedDate.Count)
            {
                var selectedEvent = eventsForSelectedDate[listBoxEvents.SelectedIndex];

                lblEventInfo.Text = $"Event: {selectedEvent.Name}\n" +
                                    $"Outfit: {(string.IsNullOrEmpty(selectedEvent.OutfitName) ? "N/A" : selectedEvent.OutfitName)}\n" +
                                    $"Date and Time: {selectedEvent.Date:dd/MM/yyyy HH:mm}";

                if (selectedEvent.idOutfit > 0)
                {
                    try
                    {
                        string outfitUrl = $"https://localhost:44337/api/outfits/{selectedEvent.idOutfit}";
                        var response = await client.GetAsync(outfitUrl);

                        if (response.IsSuccessStatusCode)
                        {
                            var json = await response.Content.ReadAsStringAsync();
                            var outfit = JsonConvert.DeserializeObject<Outfits>(json);

                            ShowOutfitImages(outfit);
                        }
                        else
                        {
                            flowPanelOutfit_Event.Controls.Clear();
                            MessageBox.Show("Could not load outfit details for this event.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading outfit: " + ex.Message);
                    }
                }
                else
                {
                    flowPanelOutfit_Event.Controls.Clear();
                    MessageBox.Show("This event does not have an associated outfit.");
                }
            }
        }
        // COMPLAINTS TAB

        private async void btnSubmitComplaint_Click(object sender, EventArgs e)
        {
            string subject = txtSubject.Text.Trim();
            string description = txtDomain.Text.Trim();
            string domainDisplay = comboBoxDomain.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(subject) || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(domainDisplay))
            {
                MessageBox.Show("Please fill all the fields.");
                return;
            }

            string domainInternal = "Other";
            if (domainDisplay == "Functions not working correctly")
                domainInternal = "Functionality";
            else if (domainDisplay == "Faulty displays on the screen")
                domainInternal = "VisualIssue";
            else if (domainDisplay == "Slow app performance")
                domainInternal = "Performance";
            else if (domainDisplay == "Other issue or suggestion")
                domainInternal = "Other";

            var complaint = new ComplaintDTO
            {
                idUser = LoggedInUserId,
                Subject = subject,
                Text = description,
                Domain = domainInternal
            };

            try
            {
                var content = new StringContent(System.Text.Json.JsonSerializer.Serialize(complaint), System.Text.Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:44337/api/complaints/submit", content);

                string responseText = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Complaint sent successfully!");
                    txtSubject.Clear();
                    txtDomain.Clear();
                    comboBoxDomain.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Error sending complaint: " + response.StatusCode + "\n" + responseText);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // TAB ACCOUNT - VERIFY CREDENTIALS

        private async void btnVerifyCredentials_Click(object sender, EventArgs e)
        {

            string username = textBoxOldUsername.Text.Trim();
            string password = textBoxOldPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            var verifyRequest = new
            {
                Username = username,
                Password = password
            };

            try
            {
                var content = new StringContent(
                    System.Text.Json.JsonSerializer.Serialize(verifyRequest),
                    System.Text.Encoding.UTF8,
                    "application/json"
                );

                var response = await client.PostAsync("https://localhost:44337/api/account/verify", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Credentials verified! You can now update your account.");

                    // Enable and style new username controls
                    labelNewUsername.Enabled = true;
                    textBoxNewUsername.Enabled = true;
                    textBoxNewUsername.BackColor = Color.LavenderBlush;

                    // Enable and style new password controls
                    labelNewPassword.Enabled = true;
                    textBoxNewPassword.Enabled = true;
                    textBoxNewPassword.BackColor = Color.LavenderBlush;

                    // Enable and style the Update Account button
                    btnUpdateAccount.Enabled = true;
                    btnUpdateAccount.BackColor = Color.LavenderBlush;
                    btnUpdateAccount.ForeColor = Color.RosyBrown;
                    btnUpdateAccount.UseVisualStyleBackColor = false;
                }
                else
                {
                    MessageBox.Show("Invalid credentials.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error verifying credentials: " + ex.Message);
            }
        }

        // UPDATE ACCOUNT
        private async void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            string newUsername = textBoxNewUsername.Text.Trim();
            string newPassword = textBoxNewPassword.Text.Trim();

            if (string.IsNullOrEmpty(newUsername) || string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Please fill in both new username and new password.");
                return;
            }

            var updateRequest = new
            {
                Id = LoggedInUserId,
                NewUsername = newUsername,
                NewPassword = newPassword,
                AccountType = "User"
            };

            try
            {
                var content = new StringContent(System.Text.Json.JsonSerializer.Serialize(updateRequest), System.Text.Encoding.UTF8, "application/json");
                var response = await client.PutAsync("https://localhost:44337/api/account/update", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Account updated successfully!");
             
                    textBoxNewUsername.Clear();
                    textBoxNewPassword.Clear();
                    labelNewUsername.Enabled = false;
                    textBoxNewUsername.Enabled = false;
                    labelNewPassword.Enabled = false;
                    textBoxNewPassword.Enabled = false;
                    btnUpdateAccount.Enabled = true;
                }
                else
                {
                    string error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Error updating account. This username is already taken!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        // LOGOUT
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnViewComplaints_Click(object sender, EventArgs e)
        {
            UserComplaintsForm form = new UserComplaintsForm(LoggedInUserId);
            form.ShowDialog();
            
        }

        //For design
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage tabPage = tabControl1.TabPages[e.Index];
            Rectangle rect = tabControl1.GetTabRect(e.Index);
            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

            using (Brush textBrush = new SolidBrush(isSelected ? Color.DeepPink : Color.Pink))
            {
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                e.Graphics.DrawString(tabPage.Text, this.Font, textBrush, rect, sf);
            }
        }

        
    }
}
