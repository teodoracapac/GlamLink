// Updated AddEventForm with visual style matching AddOutfits
namespace GlamLinkForm
{
    partial class AddEventForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEventForm));
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmAdd = new System.Windows.Forms.Button();
            this.lblSelectedDate = new System.Windows.Forms.Label();
            this.comboOutfits = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWeatherDate = new System.Windows.Forms.Label();
            this.lblWeatherSummary = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picWeatherInfo = new System.Windows.Forms.PictureBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.btnCheckWeather = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutOutfitsPreview = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEventName
            // 
            this.txtEventName.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventName.ForeColor = System.Drawing.Color.RosyBrown;
            this.txtEventName.Location = new System.Drawing.Point(101, 139);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(162, 34);
            this.txtEventName.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(101, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Event name:";
            // 
            // btnConfirmAdd
            // 
            this.btnConfirmAdd.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnConfirmAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmAdd.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnConfirmAdd.Location = new System.Drawing.Point(511, 349);
            this.btnConfirmAdd.Name = "btnConfirmAdd";
            this.btnConfirmAdd.Size = new System.Drawing.Size(200, 40);
            this.btnConfirmAdd.TabIndex = 11;
            this.btnConfirmAdd.Text = "Add event";
            this.btnConfirmAdd.UseVisualStyleBackColor = false;
            this.btnConfirmAdd.Click += new System.EventHandler(this.btnConfirmAdd_Click);
            // 
            // lblSelectedDate
            // 
            this.lblSelectedDate.AutoSize = true;
            this.lblSelectedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedDate.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblSelectedDate.Location = new System.Drawing.Point(101, 230);
            this.lblSelectedDate.Name = "lblSelectedDate";
            this.lblSelectedDate.Size = new System.Drawing.Size(85, 29);
            this.lblSelectedDate.TabIndex = 10;
            this.lblSelectedDate.Text = "label2";
            // 
            // comboOutfits
            // 
            this.comboOutfits.BackColor = System.Drawing.Color.LavenderBlush;
            this.comboOutfits.ForeColor = System.Drawing.Color.RosyBrown;
            this.comboOutfits.Location = new System.Drawing.Point(105, 340);
            this.comboOutfits.Name = "comboOutfits";
            this.comboOutfits.Size = new System.Drawing.Size(250, 24);
            this.comboOutfits.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RosyBrown;
            this.label2.Location = new System.Drawing.Point(110, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(452, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "What outfit do you want to wear, Diva?";
            // 
            // lblWeatherDate
            // 
            this.lblWeatherDate.AutoSize = true;
            this.lblWeatherDate.BackColor = System.Drawing.Color.Transparent;
            this.lblWeatherDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeatherDate.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblWeatherDate.Location = new System.Drawing.Point(507, 184);
            this.lblWeatherDate.Name = "lblWeatherDate";
            this.lblWeatherDate.Size = new System.Drawing.Size(168, 29);
            this.lblWeatherDate.TabIndex = 7;
            this.lblWeatherDate.Text = "Weatherdate:";
            // 
            // lblWeatherSummary
            // 
            this.lblWeatherSummary.AutoSize = true;
            this.lblWeatherSummary.BackColor = System.Drawing.Color.Transparent;
            this.lblWeatherSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeatherSummary.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblWeatherSummary.Location = new System.Drawing.Point(507, 220);
            this.lblWeatherSummary.Name = "lblWeatherSummary";
            this.lblWeatherSummary.Size = new System.Drawing.Size(221, 29);
            this.lblWeatherSummary.TabIndex = 6;
            this.lblWeatherSummary.Text = "Weathersummary:";
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.BackColor = System.Drawing.Color.Transparent;
            this.lblTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperature.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblTemperature.Location = new System.Drawing.Point(507, 263);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(171, 29);
            this.lblTemperature.TabIndex = 5;
            this.lblTemperature.Text = "Temperature:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RosyBrown;
            this.label3.Location = new System.Drawing.Point(507, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Your location:";
            // 
            // picWeatherInfo
            // 
            this.picWeatherInfo.BackColor = System.Drawing.Color.Transparent;
            this.picWeatherInfo.Location = new System.Drawing.Point(794, 184);
            this.picWeatherInfo.Name = "picWeatherInfo";
            this.picWeatherInfo.Size = new System.Drawing.Size(81, 70);
            this.picWeatherInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWeatherInfo.TabIndex = 3;
            this.picWeatherInfo.TabStop = false;
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtCity.ForeColor = System.Drawing.Color.RosyBrown;
            this.txtCity.Location = new System.Drawing.Point(511, 147);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(162, 23);
            this.txtCity.TabIndex = 2;
            // 
            // btnCheckWeather
            // 
            this.btnCheckWeather.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnCheckWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckWeather.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnCheckWeather.Location = new System.Drawing.Point(511, 303);
            this.btnCheckWeather.Name = "btnCheckWeather";
            this.btnCheckWeather.Size = new System.Drawing.Size(200, 40);
            this.btnCheckWeather.TabIndex = 1;
            this.btnCheckWeather.Text = "Check weather";
            this.btnCheckWeather.UseVisualStyleBackColor = false;
            this.btnCheckWeather.Click += new System.EventHandler(this.btnCheckWeather_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RosyBrown;
            this.label4.Location = new System.Drawing.Point(101, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Selected date:";
            // 
            // flowLayoutOutfitsPreview
            // 
            this.flowLayoutOutfitsPreview.AutoScroll = true;
            this.flowLayoutOutfitsPreview.Location = new System.Drawing.Point(101, 455);
            this.flowLayoutOutfitsPreview.Name = "flowLayoutOutfitsPreview";
            this.flowLayoutOutfitsPreview.Size = new System.Drawing.Size(370, 133);
            this.flowLayoutOutfitsPreview.TabIndex = 14;
            // 
            // AddEventForm
            // 
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = global::GlamLinkForm.Properties.Resources.iPiccy_img;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.flowLayoutOutfitsPreview);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCheckWeather);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.picWeatherInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.lblWeatherSummary);
            this.Controls.Add(this.lblWeatherDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboOutfits);
            this.Controls.Add(this.lblSelectedDate);
            this.Controls.Add(this.btnConfirmAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEventName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Event";
            this.Load += new System.EventHandler(this.AddEventForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmAdd;
        private System.Windows.Forms.Label lblSelectedDate;
        private System.Windows.Forms.ComboBox comboOutfits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWeatherDate;
        private System.Windows.Forms.Label lblWeatherSummary;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picWeatherInfo;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button btnCheckWeather;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutOutfitsPreview;
    }
}
