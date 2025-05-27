using GlamLinkForm;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace GlamLinkClient
{
    public partial class LoginForm : Form
    {
        private readonly HttpClient _httpClient;

        public LoginForm()
        {
            InitializeComponent();

            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:44337/api/Auth/")
            };

            txtPassword.UseSystemPasswordChar = true;
        }

        public class LoginResponse
        {
            public string message { get; set; }
            public int userId { get; set; }
            
        }

        public class AdminLoginResponse
        {
            public string message { get; set; }
            public int adminId { get; set; }

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            var user = new
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text
            };

            try
            {
                var response = await _httpClient.PostAsJsonAsync("login", user);
                string rawResponse = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    try
                    {
                        var loginResult = JsonSerializer.Deserialize<LoginResponse>(rawResponse);
                        MessageBox.Show("Login successful!");

                        MainPage mainPage = new MainPage(loginResult.userId);
                        this.Hide();
                        mainPage.Show();
                    }
                    catch
                    {
                        MessageBox.Show("Login succeeded but failed to parse JSON response.\nRaw: " + rawResponse);
                    }
                }
                else
                {
                    MessageBox.Show("Login failed:\n" + rawResponse);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Request failed:\n" + ex.Message);
            }
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            var user = new
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text
            };

            try
            {
                var response = await _httpClient.PostAsJsonAsync("register", user);
                var result = await response.Content.ReadAsStringAsync();

                MessageBox.Show(response.IsSuccessStatusCode ? "Registration successful!" : "Registration failed: " + result);
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Invalid credentials!");
            }
        }

        private async void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }
            var admin = new
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text
            };

            try
            {
                var response = await _httpClient.PostAsJsonAsync("loginadmin", admin);
                string rawResponse = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    try
                    {
                        var loginResult = JsonSerializer.Deserialize<AdminLoginResponse>(rawResponse);
                        MessageBox.Show("Admin login successful!");

                        AdminForm adminForm = new AdminForm(loginResult.adminId); 
                        this.Hide();
                        adminForm.Show();
                    }
                    catch
                    {
                        MessageBox.Show("Login succeeded but failed to parse JSON response.\nRaw: " + rawResponse);
                    }
                }
                else
                {
                    MessageBox.Show("Admin login failed: Invalid credentials!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Invalid credentials or server error.");
            }
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !cbShowPassword.Checked;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
