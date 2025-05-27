using System.Drawing;

namespace GlamLinkForm
{
    partial class AdminForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mngUsers = new System.Windows.Forms.TabPage();
            this.btnDelUser = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.tabComplaints = new System.Windows.Forms.TabPage();
            this.btnSolved = new System.Windows.Forms.Button();
            this.dgvComplaints = new System.Windows.Forms.DataGridView();
            this.UpdateAcc = new System.Windows.Forms.TabPage();
            this.labelVerifyInfo = new System.Windows.Forms.Label();
            this.labelOldUsername = new System.Windows.Forms.Label();
            this.textBoxOldUsername = new System.Windows.Forms.TextBox();
            this.labelOldPassword = new System.Windows.Forms.Label();
            this.textBoxOldPassword = new System.Windows.Forms.TextBox();
            this.btnVerifyCredentials = new System.Windows.Forms.Button();
            this.labelNewUsername = new System.Windows.Forms.Label();
            this.textBoxNewUsername = new System.Windows.Forms.TextBox();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.mngUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.tabComplaints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplaints)).BeginInit();
            this.UpdateAcc.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mngUsers);
            this.tabControl1.Controls.Add(this.tabComplaints);
            this.tabControl1.Controls.Add(this.UpdateAcc);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(4, 236);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1037, 568);
            this.tabControl1.TabIndex = 0;
            // 
            // mngUsers
            // 
            this.mngUsers.BackColor = System.Drawing.Color.MediumVioletRed;
            this.mngUsers.BackgroundImage = global::GlamLinkForm.Properties.Resources.luxa_org_opacity_changed___ipiccy_image__1___1___1_;
            this.mngUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mngUsers.Controls.Add(this.btnDelUser);
            this.mngUsers.Controls.Add(this.dgvUsers);
            this.mngUsers.Location = new System.Drawing.Point(4, 37);
            this.mngUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mngUsers.Name = "mngUsers";
            this.mngUsers.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mngUsers.Size = new System.Drawing.Size(1029, 527);
            this.mngUsers.TabIndex = 0;
            this.mngUsers.Text = "Manage Users";
            // 
            // btnDelUser
            // 
            this.btnDelUser.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnDelUser.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnDelUser.Location = new System.Drawing.Point(474, 266);
            this.btnDelUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelUser.Name = "btnDelUser";
            this.btnDelUser.Size = new System.Drawing.Size(152, 43);
            this.btnDelUser.TabIndex = 1;
            this.btnDelUser.Text = "Delete user";
            this.btnDelUser.UseVisualStyleBackColor = false;
            this.btnDelUser.Click += new System.EventHandler(this.btnDelUser_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.GridColor = System.Drawing.Color.Pink;
            this.dgvUsers.Location = new System.Drawing.Point(272, 31);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(535, 225);
            this.dgvUsers.TabIndex = 0;
            // 
            // tabComplaints
            // 
            this.tabComplaints.BackColor = System.Drawing.Color.LavenderBlush;
            this.tabComplaints.BackgroundImage = global::GlamLinkForm.Properties.Resources.luxa_org_opacity_changed___ipiccy_image__1___1___1_;
            this.tabComplaints.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabComplaints.Controls.Add(this.btnSolved);
            this.tabComplaints.Controls.Add(this.dgvComplaints);
            this.tabComplaints.ForeColor = System.Drawing.Color.RosyBrown;
            this.tabComplaints.Location = new System.Drawing.Point(4, 37);
            this.tabComplaints.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabComplaints.Name = "tabComplaints";
            this.tabComplaints.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabComplaints.Size = new System.Drawing.Size(1029, 527);
            this.tabComplaints.TabIndex = 1;
            this.tabComplaints.Text = "Complaints";
            // 
            // btnSolved
            // 
            this.btnSolved.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSolved.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnSolved.Location = new System.Drawing.Point(8, 118);
            this.btnSolved.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSolved.Name = "btnSolved";
            this.btnSolved.Size = new System.Drawing.Size(145, 69);
            this.btnSolved.TabIndex = 1;
            this.btnSolved.Text = "Complaint solved!";
            this.btnSolved.UseVisualStyleBackColor = false;
            this.btnSolved.Click += new System.EventHandler(this.btnSolved_Click);
            // 
            // dgvComplaints
            // 
            this.dgvComplaints.BackgroundColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComplaints.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvComplaints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComplaints.Location = new System.Drawing.Point(169, 23);
            this.dgvComplaints.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvComplaints.Name = "dgvComplaints";
            this.dgvComplaints.RowHeadersWidth = 51;
            this.dgvComplaints.RowTemplate.Height = 24;
            this.dgvComplaints.Size = new System.Drawing.Size(750, 249);
            this.dgvComplaints.TabIndex = 0;
            // 
            // UpdateAcc
            // 
            this.UpdateAcc.BackColor = System.Drawing.Color.RosyBrown;
            this.UpdateAcc.BackgroundImage = global::GlamLinkForm.Properties.Resources.luxa_org_opacity_changed___ipiccy_image__1___1___1_;
            this.UpdateAcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UpdateAcc.Controls.Add(this.labelVerifyInfo);
            this.UpdateAcc.Controls.Add(this.labelOldUsername);
            this.UpdateAcc.Controls.Add(this.textBoxOldUsername);
            this.UpdateAcc.Controls.Add(this.labelOldPassword);
            this.UpdateAcc.Controls.Add(this.textBoxOldPassword);
            this.UpdateAcc.Controls.Add(this.btnVerifyCredentials);
            this.UpdateAcc.Controls.Add(this.labelNewUsername);
            this.UpdateAcc.Controls.Add(this.textBoxNewUsername);
            this.UpdateAcc.Controls.Add(this.labelNewPassword);
            this.UpdateAcc.Controls.Add(this.textBoxNewPassword);
            this.UpdateAcc.Controls.Add(this.btnUpdateAccount);
            this.UpdateAcc.Controls.Add(this.btnLogout);
            this.UpdateAcc.ForeColor = System.Drawing.Color.RosyBrown;
            this.UpdateAcc.Location = new System.Drawing.Point(4, 37);
            this.UpdateAcc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UpdateAcc.Name = "UpdateAcc";
            this.UpdateAcc.Size = new System.Drawing.Size(1029, 527);
            this.UpdateAcc.TabIndex = 2;
            this.UpdateAcc.Text = "Update Account";
            // 
            // labelVerifyInfo
            // 
            this.labelVerifyInfo.BackColor = System.Drawing.Color.LavenderBlush;
            this.labelVerifyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVerifyInfo.ForeColor = System.Drawing.Color.RosyBrown;
            this.labelVerifyInfo.Location = new System.Drawing.Point(348, 15);
            this.labelVerifyInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVerifyInfo.Name = "labelVerifyInfo";
            this.labelVerifyInfo.Size = new System.Drawing.Size(356, 29);
            this.labelVerifyInfo.TabIndex = 24;
            this.labelVerifyInfo.Text = "Confirm your credentials before updating:";
            // 
            // labelOldUsername
            // 
            this.labelOldUsername.BackColor = System.Drawing.Color.LavenderBlush;
            this.labelOldUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOldUsername.ForeColor = System.Drawing.Color.RosyBrown;
            this.labelOldUsername.Location = new System.Drawing.Point(357, 57);
            this.labelOldUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOldUsername.Name = "labelOldUsername";
            this.labelOldUsername.Size = new System.Drawing.Size(110, 29);
            this.labelOldUsername.TabIndex = 25;
            this.labelOldUsername.Text = "Username:";
            // 
            // textBoxOldUsername
            // 
            this.textBoxOldUsername.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBoxOldUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOldUsername.ForeColor = System.Drawing.Color.RosyBrown;
            this.textBoxOldUsername.Location = new System.Drawing.Point(494, 54);
            this.textBoxOldUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxOldUsername.Name = "textBoxOldUsername";
            this.textBoxOldUsername.Size = new System.Drawing.Size(200, 30);
            this.textBoxOldUsername.TabIndex = 26;
            // 
            // labelOldPassword
            // 
            this.labelOldPassword.BackColor = System.Drawing.Color.LavenderBlush;
            this.labelOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOldPassword.ForeColor = System.Drawing.Color.RosyBrown;
            this.labelOldPassword.Location = new System.Drawing.Point(357, 99);
            this.labelOldPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOldPassword.Name = "labelOldPassword";
            this.labelOldPassword.Size = new System.Drawing.Size(110, 29);
            this.labelOldPassword.TabIndex = 27;
            this.labelOldPassword.Text = "Password:";
            // 
            // textBoxOldPassword
            // 
            this.textBoxOldPassword.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBoxOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOldPassword.ForeColor = System.Drawing.Color.RosyBrown;
            this.textBoxOldPassword.Location = new System.Drawing.Point(494, 99);
            this.textBoxOldPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxOldPassword.Name = "textBoxOldPassword";
            this.textBoxOldPassword.PasswordChar = '*';
            this.textBoxOldPassword.Size = new System.Drawing.Size(200, 30);
            this.textBoxOldPassword.TabIndex = 28;
            // 
            // btnVerifyCredentials
            // 
            this.btnVerifyCredentials.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnVerifyCredentials.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifyCredentials.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnVerifyCredentials.Location = new System.Drawing.Point(411, 148);
            this.btnVerifyCredentials.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVerifyCredentials.Name = "btnVerifyCredentials";
            this.btnVerifyCredentials.Size = new System.Drawing.Size(196, 48);
            this.btnVerifyCredentials.TabIndex = 29;
            this.btnVerifyCredentials.Text = "Verify";
            this.btnVerifyCredentials.UseVisualStyleBackColor = false;
            this.btnVerifyCredentials.Click += new System.EventHandler(this.btnVerifyCredentials_Click);
            // 
            // labelNewUsername
            // 
            this.labelNewUsername.BackColor = System.Drawing.Color.LavenderBlush;
            this.labelNewUsername.Enabled = false;
            this.labelNewUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewUsername.ForeColor = System.Drawing.Color.RosyBrown;
            this.labelNewUsername.Location = new System.Drawing.Point(311, 223);
            this.labelNewUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNewUsername.Name = "labelNewUsername";
            this.labelNewUsername.Size = new System.Drawing.Size(156, 29);
            this.labelNewUsername.TabIndex = 30;
            this.labelNewUsername.Text = "New Username:";
            // 
            // textBoxNewUsername
            // 
            this.textBoxNewUsername.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBoxNewUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewUsername.ForeColor = System.Drawing.Color.RosyBrown;
            this.textBoxNewUsername.Location = new System.Drawing.Point(494, 222);
            this.textBoxNewUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNewUsername.Name = "textBoxNewUsername";
            this.textBoxNewUsername.Size = new System.Drawing.Size(200, 30);
            this.textBoxNewUsername.TabIndex = 31;
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.BackColor = System.Drawing.Color.LavenderBlush;
            this.labelNewPassword.Enabled = false;
            this.labelNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewPassword.ForeColor = System.Drawing.Color.RosyBrown;
            this.labelNewPassword.Location = new System.Drawing.Point(311, 267);
            this.labelNewPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(156, 29);
            this.labelNewPassword.TabIndex = 32;
            this.labelNewPassword.Text = "New Password:";
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBoxNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewPassword.ForeColor = System.Drawing.Color.RosyBrown;
            this.textBoxNewPassword.Location = new System.Drawing.Point(494, 267);
            this.textBoxNewPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.PasswordChar = '*';
            this.textBoxNewPassword.Size = new System.Drawing.Size(200, 30);
            this.textBoxNewPassword.TabIndex = 33;
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnUpdateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAccount.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnUpdateAccount.Location = new System.Drawing.Point(411, 310);
            this.btnUpdateAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(196, 48);
            this.btnUpdateAccount.TabIndex = 34;
            this.btnUpdateAccount.Text = "Update Account";
            this.btnUpdateAccount.UseVisualStyleBackColor = false;
            this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnLogout.Location = new System.Drawing.Point(855, 310);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(121, 48);
            this.btnLogout.TabIndex = 35;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepPink;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.ForeColor = System.Drawing.SystemColors.Window;
            this.panel1.Location = new System.Drawing.Point(0, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 259);
            this.panel1.TabIndex = 2;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1061, 538);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GlamLink - Admin";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.mngUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.tabComplaints.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplaints)).EndInit();
            this.UpdateAcc.ResumeLayout(false);
            this.UpdateAcc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage mngUsers;
        private System.Windows.Forms.TabPage tabComplaints;
        private System.Windows.Forms.TabPage UpdateAcc;
        private System.Windows.Forms.Label labelVerifyInfo;
        private System.Windows.Forms.Label labelOldUsername;
        private System.Windows.Forms.TextBox textBoxOldUsername;
        private System.Windows.Forms.Label labelOldPassword;
        private System.Windows.Forms.TextBox textBoxOldPassword;
        private System.Windows.Forms.Button btnVerifyCredentials;
        private System.Windows.Forms.Label labelNewUsername;
        private System.Windows.Forms.TextBox textBoxNewUsername;
        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Button btnUpdateAccount;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSolved;
        private System.Windows.Forms.DataGridView dgvComplaints;
        private System.Windows.Forms.Button btnDelUser;
        private System.Windows.Forms.DataGridView dgvUsers;
    }
}