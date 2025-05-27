using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace GlamLinkForm
{
    public partial class AdminForm : Form
    {
        private int _adminId;
        private static readonly HttpClient client = new HttpClient();

        public class Complaints
        {
            public int idComplaint { get; set; }
            public string Subject { get; set; }
            public string Text { get; set; }
            public int idUser { get; set; }
            public string Username { get; set; }
            public string Status { get; set; }
        }

        public class Users
        {
            public int idUser { get; set; }
            public string Username { get; set; }
        }

        public AdminForm(int adminId)
        {
            InitializeComponent();
            _adminId = adminId;
            dgvComplaints.CellFormatting += dgvComplaints_CellFormatting;

            // Initial state for credential fields
            textBoxNewUsername.Enabled = false;
            textBoxNewUsername.BackColor = Color.LightGray;
            textBoxNewPassword.Enabled = false;
            textBoxNewPassword.BackColor = Color.LightGray;

            // Initial state and style for Update Account button
            btnUpdateAccount.Enabled = false;
            btnUpdateAccount.BackColor = Color.LightGray;
            btnUpdateAccount.ForeColor = Color.Gray;
            btnUpdateAccount.UseVisualStyleBackColor = false;
        }

        private async void AdminForm_Load(object sender, EventArgs e)
        {
            tabControl1.DrawItem += new DrawItemEventHandler(this.tabControl1_DrawItem);
            await LoadComplaintsAsync();
            await LoadUsersAsync();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

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
                var content = new StringContent(System.Text.Json.JsonSerializer.Serialize(verifyRequest), System.Text.Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:44337/api/account/verify", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Credentials verified! You can now update your account.");

                    labelNewUsername.Enabled = true;
                    textBoxNewUsername.Enabled = true;
                    textBoxNewUsername.BackColor = Color.LavenderBlush;

                    labelNewPassword.Enabled = true;
                    textBoxNewPassword.Enabled = true;
                    textBoxNewPassword.BackColor = Color.LavenderBlush;

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

        private async void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            string newUsername = textBoxNewUsername.Text.Trim();
            string newPassword = textBoxNewPassword.Text.Trim();

            if (string.IsNullOrEmpty(newUsername) || string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Please fill in both new username and new password.");
                return;
            }

            try
            {
                string url = "https://localhost:44337/api/account/allUsers";
                var users = await client.GetFromJsonAsync<List<Users>>(url);

                if (users.Any(u => u.Username.Equals(newUsername, StringComparison.OrdinalIgnoreCase) && u.idUser != _adminId))
                {
                    MessageBox.Show("This username is already taken. Please choose another one.");
                    return;
                }

                var updateRequest = new
                {
                    Id = _adminId,
                    NewUsername = newUsername,
                    NewPassword = newPassword,
                    AccountType = "Admin"
                };

                var content = new StringContent(System.Text.Json.JsonSerializer.Serialize(updateRequest), System.Text.Encoding.UTF8, "application/json");
                var response = await client.PutAsync("https://localhost:44337/api/account/update", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Admin account updated successfully!");

                    textBoxNewUsername.Clear();
                    textBoxNewPassword.Clear();
                    labelNewUsername.Enabled = false;
                    textBoxNewUsername.Enabled = false;
                    textBoxNewUsername.BackColor = Color.LightGray;
                    labelNewPassword.Enabled = false;
                    textBoxNewPassword.Enabled = false;
                    textBoxNewPassword.BackColor = Color.LightGray;

                    btnUpdateAccount.Enabled = false;
                    btnUpdateAccount.BackColor = Color.LightGray;
                    btnUpdateAccount.ForeColor = Color.Gray;
                    btnUpdateAccount.UseVisualStyleBackColor = false;
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

        private async Task LoadComplaintsAsync()
        {
            try
            {
                string url = $"https://localhost:44337/api/complaints/admin/{_adminId}";
                var complaints = await client.GetFromJsonAsync<List<Complaints>>(url);
                dgvComplaints.AutoGenerateColumns = false;
                dgvComplaints.Columns.Clear();

                dgvComplaints.Columns.Add(new DataGridViewTextBoxColumn { Name = "Subject", HeaderText = "Subject", DataPropertyName = "Subject" });
                dgvComplaints.Columns.Add(new DataGridViewTextBoxColumn { Name = "Text", HeaderText = "Text", DataPropertyName = "Text" });
                dgvComplaints.Columns.Add(new DataGridViewTextBoxColumn { Name = "Status", HeaderText = "Status", DataPropertyName = "Status" });

                dgvComplaints.DataSource = complaints;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading complaints: " + ex.Message);
            }
        }

        private async void btnSolved_Click(object sender, EventArgs e)
        {
            if (dgvComplaints.CurrentRow == null)
            {
                MessageBox.Show("Please select a complaint.");
                return;
            }

            var selectedComplaint = (Complaints)dgvComplaints.CurrentRow.DataBoundItem;

            if (selectedComplaint.Status?.ToLower() == "solved")
            {
                MessageBox.Show("The selected complaint is already solved!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int complaintId = selectedComplaint.idComplaint;
            var confirm = MessageBox.Show("Are you sure you want to mark this complaint as solved?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    string url = $"https://localhost:44337/api/complaints/mark-solved/{complaintId}";
                    var response = await client.PutAsync(url, null);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Complaint marked as solved.");
                        await LoadComplaintsAsync();
                    }
                    else
                    {
                        string error = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Failed to mark as solved:\n" + error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private async Task LoadUsersAsync()
        {
            try
            {
                dgvUsers.AutoGenerateColumns = false;
                dgvUsers.Columns.Clear();

                dgvUsers.Columns.Add(new DataGridViewTextBoxColumn { Name = "Username", HeaderText = "Username", DataPropertyName = "Username" });

                string url = "https://localhost:44337/api/account/allUsers";
                var users = await client.GetFromJsonAsync<List<Users>>(url);

                dgvUsers.DataSource = users;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load users: " + ex.Message);
            }
        }

        private async void btnDelUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            var selectedUser = (Users)dgvUsers.CurrentRow.DataBoundItem;
            int userId = selectedUser.idUser;

            var confirm = MessageBox.Show($"Are you sure you want to delete user: {selectedUser.Username}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    string url = $"https://localhost:44337/api/account/delete/{userId}";
                    var response = await client.DeleteAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("User deleted successfully.");
                        await LoadUsersAsync();
                    }
                    else
                    {
                        string error = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Failed to delete user:\n" + error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dgvComplaints_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvComplaints.Columns[e.ColumnIndex].DataPropertyName == "Status" && e.Value != null)
            {
                string status = e.Value.ToString().ToLower();
                if (status == "pending")
                {
                    e.CellStyle.BackColor = Color.Orange;
                    e.CellStyle.ForeColor = Color.White;
                }
                else if (status == "solved")
                {
                    e.CellStyle.BackColor = Color.ForestGreen;
                    e.CellStyle.ForeColor = Color.White;
                }
            }
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage tabPage = tabControl1.TabPages[e.Index];
            Rectangle rect = tabControl1.GetTabRect(e.Index);
            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

            using (Brush textBrush = new SolidBrush(isSelected ? Color.DeepPink : Color.Pink))
            {
                StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                e.Graphics.DrawString(tabPage.Text, this.Font, textBrush, rect, sf);
            }
        }
    }
}