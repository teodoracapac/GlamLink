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

namespace GlamLinkForm
{
    public partial class UserComplaintsForm : Form
    {
        private int _userId;
        private static readonly HttpClient client = new HttpClient();

        public class ComplaintDTO
        {
            public string Subject { get; set; }
            public string Text { get; set; }
            public string Status { get; set; }
        }

        public UserComplaintsForm(int userId)
        {
            InitializeComponent();
            this.Load += UserComplaintsForm_Load;
            _userId = userId;
            dgvUserComplaints.CellFormatting += dgvUserComplaints_CellFormatting;
        }

        private async void UserComplaintsForm_Load(object sender, EventArgs e)
        {
            try
            {
                string url = $"https://localhost:44337/api/complaints/user/{_userId}";
                var complaints = await client.GetFromJsonAsync<List<ComplaintDTO>>(url);

                dgvUserComplaints.AutoGenerateColumns = false;
                dgvUserComplaints.Columns.Clear(); 

                dgvUserComplaints.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Subject",
                    DataPropertyName = "Subject",
                    Width = 100
                });

                dgvUserComplaints.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Text",
                    DataPropertyName = "Text",
                    Width = 400
                });

                dgvUserComplaints.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "Status",
                    DataPropertyName = "Status",
                    Width = 100
                });

                dgvUserComplaints.DataSource = complaints;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading complaints: " + ex.Message);
            }
        }

        private void dgvUserComplaints_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvUserComplaints.Columns[e.ColumnIndex].DataPropertyName == "Status" && e.Value != null)
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


    }
}
