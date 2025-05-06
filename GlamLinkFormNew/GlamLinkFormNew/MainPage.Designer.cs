namespace WindowsFormsApp1
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            panel1 = new Panel();
            panel2 = new Panel();
            btnComplain = new Button();
            btnAccount = new Button();
            btnCalendar = new Button();
            btnOutfit = new Button();
            btnCloset = new Button();
            panelCloset = new Panel();
            panelOutfit = new Panel();
            panelCalendar = new Panel();
            panelComplain = new Panel();
            panelAccount = new Panel();
            btnCategory_Shoes = new Button();
            btnCategory_Jackets = new Button();
            btnCategory_Acc = new Button();
            btnCategory_Bottoms = new Button();
            btnCategory_Tops = new Button();
            btnCategory_Dresses = new Button();
            panel2.SuspendLayout();
            panelAccount.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Pink;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(540, 220);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Pink;
            panel2.Controls.Add(btnComplain);
            panel2.Controls.Add(btnAccount);
            panel2.Controls.Add(btnCalendar);
            panel2.Controls.Add(btnOutfit);
            panel2.Controls.Add(btnCloset);
            panel2.Location = new Point(0, 169);
            panel2.Name = "panel2";
            panel2.Size = new Size(540, 51);
            panel2.TabIndex = 1;
            // 
            // btnComplain
            // 
            btnComplain.BackColor = Color.Pink;
            btnComplain.Dock = DockStyle.Right;
            btnComplain.Font = new Font("Georgia", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnComplain.ForeColor = Color.MediumVioletRed;
            btnComplain.ImageAlign = ContentAlignment.TopCenter;
            btnComplain.Location = new Point(325, 0);
            btnComplain.Name = "btnComplain";
            btnComplain.Size = new Size(108, 51);
            btnComplain.TabIndex = 4;
            btnComplain.Text = "Complain";
            btnComplain.UseVisualStyleBackColor = false;
            btnComplain.Click += btnComplain_Click;
            // 
            // btnAccount
            // 
            btnAccount.BackColor = Color.Pink;
            btnAccount.Dock = DockStyle.Right;
            btnAccount.Font = new Font("Georgia", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAccount.ForeColor = Color.MediumVioletRed;
            btnAccount.Location = new Point(433, 0);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(107, 51);
            btnAccount.TabIndex = 3;
            btnAccount.Text = "Account";
            btnAccount.UseVisualStyleBackColor = false;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnCalendar
            // 
            btnCalendar.BackColor = Color.Pink;
            btnCalendar.Dock = DockStyle.Left;
            btnCalendar.Font = new Font("Georgia", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCalendar.ForeColor = Color.MediumVioletRed;
            btnCalendar.Location = new Point(224, 0);
            btnCalendar.Name = "btnCalendar";
            btnCalendar.Size = new Size(103, 51);
            btnCalendar.TabIndex = 2;
            btnCalendar.Text = "Calendar";
            btnCalendar.UseVisualStyleBackColor = false;
            btnCalendar.Click += btnCalendar_Click;
            // 
            // btnOutfit
            // 
            btnOutfit.BackColor = Color.Pink;
            btnOutfit.Dock = DockStyle.Left;
            btnOutfit.Font = new Font("Georgia", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnOutfit.ForeColor = Color.MediumVioletRed;
            btnOutfit.Location = new Point(110, 0);
            btnOutfit.Name = "btnOutfit";
            btnOutfit.Size = new Size(114, 51);
            btnOutfit.TabIndex = 1;
            btnOutfit.Text = "Outfits";
            btnOutfit.UseVisualStyleBackColor = false;
            btnOutfit.Click += btnOutfit_Click;
            // 
            // btnCloset
            // 
            btnCloset.BackColor = Color.Pink;
            btnCloset.BackgroundImageLayout = ImageLayout.Center;
            btnCloset.Dock = DockStyle.Left;
            btnCloset.Font = new Font("Georgia", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCloset.ForeColor = Color.MediumVioletRed;
            btnCloset.Location = new Point(0, 0);
            btnCloset.Name = "btnCloset";
            btnCloset.Size = new Size(110, 51);
            btnCloset.TabIndex = 0;
            btnCloset.Text = "Closet";
            btnCloset.UseVisualStyleBackColor = false;
            btnCloset.Click += btnCloset_Click;
            // 
            // panelCloset
            // 
            panelCloset.Dock = DockStyle.Fill;
            panelCloset.Location = new Point(0, 220);
            panelCloset.Name = "panelCloset";
            panelCloset.Size = new Size(540, 389);
            panelCloset.TabIndex = 2;
            // 
            // panelOutfit
            // 
            panelOutfit.Dock = DockStyle.Top;
            panelOutfit.Location = new Point(0, 1377);
            panelOutfit.Name = "panelOutfit";
            panelOutfit.Size = new Size(540, 389);
            panelOutfit.TabIndex = 0;
            panelOutfit.Visible = false;
            // 
            // panelCalendar
            // 
            panelCalendar.Dock = DockStyle.Top;
            panelCalendar.Location = new Point(0, 988);
            panelCalendar.Name = "panelCalendar";
            panelCalendar.Size = new Size(540, 389);
            panelCalendar.TabIndex = 0;
            panelCalendar.Visible = false;
            // 
            // panelComplain
            // 
            panelComplain.Dock = DockStyle.Top;
            panelComplain.Location = new Point(0, 609);
            panelComplain.Name = "panelComplain";
            panelComplain.Size = new Size(540, 379);
            panelComplain.TabIndex = 0;
            panelComplain.Visible = false;
            // 
            // panelAccount
            // 
            panelAccount.BackColor = Color.Plum;
            panelAccount.Controls.Add(btnCategory_Shoes);
            panelAccount.Controls.Add(btnCategory_Jackets);
            panelAccount.Controls.Add(btnCategory_Acc);
            panelAccount.Controls.Add(btnCategory_Bottoms);
            panelAccount.Controls.Add(btnCategory_Tops);
            panelAccount.Controls.Add(btnCategory_Dresses);
            panelAccount.Dock = DockStyle.Top;
            panelAccount.Location = new Point(0, 220);
            panelAccount.Name = "panelAccount";
            panelAccount.Size = new Size(540, 389);
            panelAccount.TabIndex = 0;
            panelAccount.Visible = false;
            // 
            // btnCategory_Shoes
            // 
            btnCategory_Shoes.Location = new Point(22, 307);
            btnCategory_Shoes.Name = "btnCategory_Shoes";
            btnCategory_Shoes.Size = new Size(105, 36);
            btnCategory_Shoes.TabIndex = 5;
            btnCategory_Shoes.Text = "Shoes";
            btnCategory_Shoes.UseVisualStyleBackColor = true;
            // 
            // btnCategory_Jackets
            // 
            btnCategory_Jackets.Location = new Point(22, 256);
            btnCategory_Jackets.Name = "btnCategory_Jackets";
            btnCategory_Jackets.Size = new Size(105, 36);
            btnCategory_Jackets.TabIndex = 4;
            btnCategory_Jackets.Text = "Jackets";
            btnCategory_Jackets.UseVisualStyleBackColor = true;
            // 
            // btnCategory_Acc
            // 
            btnCategory_Acc.Location = new Point(22, 205);
            btnCategory_Acc.Name = "btnCategory_Acc";
            btnCategory_Acc.Size = new Size(105, 36);
            btnCategory_Acc.TabIndex = 3;
            btnCategory_Acc.Text = "Accessories";
            btnCategory_Acc.UseVisualStyleBackColor = true;
            // 
            // btnCategory_Bottoms
            // 
            btnCategory_Bottoms.Location = new Point(22, 95);
            btnCategory_Bottoms.Name = "btnCategory_Bottoms";
            btnCategory_Bottoms.Size = new Size(105, 36);
            btnCategory_Bottoms.TabIndex = 2;
            btnCategory_Bottoms.Text = "Bottoms";
            btnCategory_Bottoms.UseVisualStyleBackColor = true;
            // 
            // btnCategory_Tops
            // 
            btnCategory_Tops.Location = new Point(22, 151);
            btnCategory_Tops.Name = "btnCategory_Tops";
            btnCategory_Tops.Size = new Size(105, 36);
            btnCategory_Tops.TabIndex = 1;
            btnCategory_Tops.Text = "Tops";
            btnCategory_Tops.UseVisualStyleBackColor = true;
            // 
            // btnCategory_Dresses
            // 
            btnCategory_Dresses.Location = new Point(22, 37);
            btnCategory_Dresses.Name = "btnCategory_Dresses";
            btnCategory_Dresses.Size = new Size(105, 36);
            btnCategory_Dresses.TabIndex = 0;
            btnCategory_Dresses.Text = "Dresses";
            btnCategory_Dresses.UseVisualStyleBackColor = true;
            btnCategory_Dresses.Click += btnCategory_Dresses_Click;
            // 
            // MainPage
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.PaleVioletRed;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(540, 609);
            Controls.Add(panelOutfit);
            Controls.Add(panelCalendar);
            Controls.Add(panelComplain);
            Controls.Add(panelAccount);
            Controls.Add(panelCloset);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainPage";
            Text = "S";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panelAccount.ResumeLayout(false);
            ResumeLayout(false);

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

