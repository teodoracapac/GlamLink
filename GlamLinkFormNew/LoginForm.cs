using System;
using System.Diagnostics.Eventing.Reader;
using System.Net.Http;
using System.Net.Http.Json;
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

        }



        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var user = new
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text
            };

            try
            {
                var response = await _httpClient.PostAsJsonAsync("login", user);
                var result = await response.Content.ReadAsStringAsync();

                MessageBox.Show(response.IsSuccessStatusCode ? "Login successful!" : "Login failed: " + result);
                
                MainPage mainpage = new MainPage();
                this.Hide();
                mainpage.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Invalid credentials!");
            }
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: Invalid credentials!");
            }
        }

        private async void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            var admin = new
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text
            };

            try
            {
                var response = await _httpClient.PostAsJsonAsync("loginadmin", admin);
                var result = await response.Content.ReadAsStringAsync();

                MessageBox.Show(response.IsSuccessStatusCode ? "Admin login successful!" : "Admin login failed: " + result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Invalid credentials!");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
