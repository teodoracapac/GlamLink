namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnComplain = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.btnOutfit = new System.Windows.Forms.Button();
            this.btnCloset = new System.Windows.Forms.Button();
            this.panelCloset = new System.Windows.Forms.Panel();
            this.panelOutfit = new System.Windows.Forms.Panel();
            this.panelCalendar = new System.Windows.Forms.Panel();
            this.panelComplain = new System.Windows.Forms.Panel();
            this.panelAccount = new System.Windows.Forms.Panel();
            this.btnCategory_Shoes = new System.Windows.Forms.Button();
            this.btnCategory_Jackets = new System.Windows.Forms.Button();
            this.btnCategory_Acc = new System.Windows.Forms.Button();
            this.btnCategory_Bottoms = new System.Windows.Forms.Button();
            this.btnCategory_Tops = new System.Windows.Forms.Button();
            this.btnCategory_Dresses = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panelAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Pink;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 220);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Pink;
            this.panel2.Controls.Add(this.btnComplain);
            this.panel2.Controls.Add(this.btnAccount);
            this.panel2.Controls.Add(this.btnCalendar);
            this.panel2.Controls.Add(this.btnOutfit);
            this.panel2.Controls.Add(this.btnCloset);
            this.panel2.Location = new System.Drawing.Point(0, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 51);
            this.panel2.TabIndex = 1;
            // 
            // btnComplain
            // 
            this.btnComplain.BackColor = System.Drawing.Color.Pink;
            this.btnComplain.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnComplain.Font = new System.Drawing.Font("Georgia", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplain.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnComplain.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnComplain.Location = new System.Drawing.Point(325, 0);
            this.btnComplain.Name = "btnComplain";
            this.btnComplain.Size = new System.Drawing.Size(108, 51);
            this.btnComplain.TabIndex = 4;
            this.btnComplain.Text = "Complain";
            this.btnComplain.UseVisualStyleBackColor = false;
            this.btnComplain.Click += new System.EventHandler(this.btnComplain_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.Pink;
            this.btnAccount.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAccount.Font = new System.Drawing.Font("Georgia", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnAccount.Location = new System.Drawing.Point(433, 0);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(107, 51);
            this.btnAccount.TabIndex = 3;
            this.btnAccount.Text = "Account";
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnCalendar
            // 
            this.btnCalendar.BackColor = System.Drawing.Color.Pink;
            this.btnCalendar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCalendar.Font = new System.Drawing.Font("Georgia", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendar.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnCalendar.Location = new System.Drawing.Point(224, 0);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(103, 51);
            this.btnCalendar.TabIndex = 2;
            this.btnCalendar.Text = "Calendar";
            this.btnCalendar.UseVisualStyleBackColor = false;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // btnOutfit
            // 
            this.btnOutfit.BackColor = System.Drawing.Color.Pink;
            this.btnOutfit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOutfit.Font = new System.Drawing.Font("Georgia", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutfit.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnOutfit.Location = new System.Drawing.Point(110, 0);
            this.btnOutfit.Name = "btnOutfit";
            this.btnOutfit.Size = new System.Drawing.Size(114, 51);
            this.btnOutfit.TabIndex = 1;
            this.btnOutfit.Text = "Outfits";
            this.btnOutfit.UseVisualStyleBackColor = false;
            this.btnOutfit.Click += new System.EventHandler(this.btnOutfit_Click);
            // 
            // btnCloset
            // 
            this.btnCloset.BackColor = System.Drawing.Color.Pink;
            this.btnCloset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCloset.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloset.Font = new System.Drawing.Font("Georgia", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloset.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnCloset.Location = new System.Drawing.Point(0, 0);
            this.btnCloset.Name = "btnCloset";
            this.btnCloset.Size = new System.Drawing.Size(110, 51);
            this.btnCloset.TabIndex = 0;
            this.btnCloset.Text = "Closet";
            this.btnCloset.UseVisualStyleBackColor = false;
            this.btnCloset.Click += new System.EventHandler(this.btnCloset_Click);
            // 
            // panelCloset
            // 
            this.panelCloset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCloset.Location = new System.Drawing.Point(0, 220);
            this.panelCloset.Name = "panelCloset";
            this.panelCloset.Size = new System.Drawing.Size(540, 389);
            this.panelCloset.TabIndex = 2;
            // 
            // panelOutfit
            // 
            this.panelOutfit.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOutfit.Location = new System.Drawing.Point(0, 1377);
            this.panelOutfit.Name = "panelOutfit";
            this.panelOutfit.Size = new System.Drawing.Size(540, 389);
            this.panelOutfit.TabIndex = 0;
            this.panelOutfit.Visible = false;
            // 
            // panelCalendar
            // 
            this.panelCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCalendar.Location = new System.Drawing.Point(0, 988);
            this.panelCalendar.Name = "panelCalendar";
            this.panelCalendar.Size = new System.Drawing.Size(540, 389);
            this.panelCalendar.TabIndex = 0;
            this.panelCalendar.Visible = false;
            // 
            // panelComplain
            // 
            this.panelComplain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelComplain.Location = new System.Drawing.Point(0, 609);
            this.panelComplain.Name = "panelComplain";
            this.panelComplain.Size = new System.Drawing.Size(540, 379);
            this.panelComplain.TabIndex = 0;
            this.panelComplain.Visible = false;
            // 
            // panelAccount
            // 
            this.panelAccount.BackColor = System.Drawing.Color.Plum;
            this.panelAccount.Controls.Add(this.btnCategory_Shoes);
            this.panelAccount.Controls.Add(this.btnCategory_Jackets);
            this.panelAccount.Controls.Add(this.btnCategory_Acc);
            this.panelAccount.Controls.Add(this.btnCategory_Bottoms);
            this.panelAccount.Controls.Add(this.btnCategory_Tops);
            this.panelAccount.Controls.Add(this.btnCategory_Dresses);
            this.panelAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAccount.Location = new System.Drawing.Point(0, 220);
            this.panelAccount.Name = "panelAccount";
            this.panelAccount.Size = new System.Drawing.Size(540, 389);
            this.panelAccount.TabIndex = 0;
            this.panelAccount.Visible = false;
            // 
            // btnCategory_Shoes
            // 
            this.btnCategory_Shoes.Location = new System.Drawing.Point(22, 307);
            this.btnCategory_Shoes.Name = "btnCategory_Shoes";
            this.btnCategory_Shoes.Size = new System.Drawing.Size(105, 36);
            this.btnCategory_Shoes.TabIndex = 5;
            this.btnCategory_Shoes.Text = "Shoes";
            this.btnCategory_Shoes.UseVisualStyleBackColor = true;
            // 
            // btnCategory_Jackets
            // 
            this.btnCategory_Jackets.Location = new System.Drawing.Point(22, 256);
            this.btnCategory_Jackets.Name = "btnCategory_Jackets";
            this.btnCategory_Jackets.Size = new System.Drawing.Size(105, 36);
            this.btnCategory_Jackets.TabIndex = 4;
            this.btnCategory_Jackets.Text = "Jackets";
            this.btnCategory_Jackets.UseVisualStyleBackColor = true;
            // 
            // btnCategory_Acc
            // 
            this.btnCategory_Acc.Location = new System.Drawing.Point(22, 205);
            this.btnCategory_Acc.Name = "btnCategory_Acc";
            this.btnCategory_Acc.Size = new System.Drawing.Size(105, 36);
            this.btnCategory_Acc.TabIndex = 3;
            this.btnCategory_Acc.Text = "Accessories";
            this.btnCategory_Acc.UseVisualStyleBackColor = true;
            // 
            // btnCategory_Bottoms
            // 
            this.btnCategory_Bottoms.Location = new System.Drawing.Point(22, 95);
            this.btnCategory_Bottoms.Name = "btnCategory_Bottoms";
            this.btnCategory_Bottoms.Size = new System.Drawing.Size(105, 36);
            this.btnCategory_Bottoms.TabIndex = 2;
            this.btnCategory_Bottoms.Text = "Bottoms";
            this.btnCategory_Bottoms.UseVisualStyleBackColor = true;
            // 
            // btnCategory_Tops
            // 
            this.btnCategory_Tops.Location = new System.Drawing.Point(22, 151);
            this.btnCategory_Tops.Name = "btnCategory_Tops";
            this.btnCategory_Tops.Size = new System.Drawing.Size(105, 36);
            this.btnCategory_Tops.TabIndex = 1;
            this.btnCategory_Tops.Text = "Tops";
            this.btnCategory_Tops.UseVisualStyleBackColor = true;
            // 
            // btnCategory_Dresses
            // 
            this.btnCategory_Dresses.Location = new System.Drawing.Point(22, 37);
            this.btnCategory_Dresses.Name = "btnCategory_Dresses";
            this.btnCategory_Dresses.Size = new System.Drawing.Size(105, 36);
            this.btnCategory_Dresses.TabIndex = 0;
            this.btnCategory_Dresses.Text = "Dresses";
            this.btnCategory_Dresses.UseVisualStyleBackColor = true;
            this.btnCategory_Dresses.Click += new System.EventHandler(this.btnDresses_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(540, 609);
            this.Controls.Add(this.panelOutfit);
            this.Controls.Add(this.panelCalendar);
            this.Controls.Add(this.panelComplain);
            this.Controls.Add(this.panelAccount);
            this.Controls.Add(this.panelCloset);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panelAccount.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnComplain;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.Button btnOutfit;
        private System.Windows.Forms.Button btnCloset;
        private System.Windows.Forms.Panel panelCloset;
        private System.Windows.Forms.Panel panelOutfit;
        private System.Windows.Forms.Panel panelCalendar;
        private System.Windows.Forms.Panel panelComplain;
        private System.Windows.Forms.Panel panelAccount;
        private System.Windows.Forms.Button btnCategory_Shoes;
        private System.Windows.Forms.Button btnCategory_Jackets;
        private System.Windows.Forms.Button btnCategory_Acc;
        private System.Windows.Forms.Button btnCategory_Bottoms;
        private System.Windows.Forms.Button btnCategory_Tops;
        private System.Windows.Forms.Button btnCategory_Dresses;
    }
}

