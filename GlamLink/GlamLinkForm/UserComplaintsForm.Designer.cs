using System.Drawing;

namespace GlamLinkForm
{
    partial class UserComplaintsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserComplaintsForm));
            this.dgvUserComplaints = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserComplaints)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUserComplaints
            // 
            this.dgvUserComplaints.BackgroundColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserComplaints.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUserComplaints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserComplaints.EnableHeadersVisualStyles = false;
            this.dgvUserComplaints.GridColor = System.Drawing.Color.HotPink;
            this.dgvUserComplaints.Location = new System.Drawing.Point(3, 43);
            this.dgvUserComplaints.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvUserComplaints.Name = "dgvUserComplaints";
            this.dgvUserComplaints.RowHeadersWidth = 51;
            this.dgvUserComplaints.RowTemplate.Height = 24;
            this.dgvUserComplaints.Size = new System.Drawing.Size(835, 287);
            this.dgvUserComplaints.TabIndex = 0;
            // 
            // UserComplaintsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumVioletRed;
            this.BackgroundImage = global::GlamLinkForm.Properties.Resources.iPiccy_img;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 449);
            this.Controls.Add(this.dgvUserComplaints);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserComplaintsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Complaints";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserComplaints)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUserComplaints;
    }
}