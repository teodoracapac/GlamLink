namespace GlamLinkForm
{
    partial class UpdateEventForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateEventForm));
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.comboOutfits = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPreviewOutfit = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // txtEventName
            // 
            this.txtEventName.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventName.ForeColor = System.Drawing.Color.RosyBrown;
            this.txtEventName.Location = new System.Drawing.Point(269, 72);
            this.txtEventName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(246, 30);
            this.txtEventName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(56, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Event name:";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(269, 112);
            this.datePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(246, 22);
            this.datePicker.TabIndex = 2;
            // 
            // comboOutfits
            // 
            this.comboOutfits.BackColor = System.Drawing.Color.LavenderBlush;
            this.comboOutfits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboOutfits.ForeColor = System.Drawing.Color.RosyBrown;
            this.comboOutfits.FormattingEnabled = true;
            this.comboOutfits.Location = new System.Drawing.Point(269, 194);
            this.comboOutfits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboOutfits.Name = "comboOutfits";
            this.comboOutfits.Size = new System.Drawing.Size(246, 33);
            this.comboOutfits.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RosyBrown;
            this.label2.Location = new System.Drawing.Point(56, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RosyBrown;
            this.label3.Location = new System.Drawing.Point(56, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Outfit for event:";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnSaveChanges.Location = new System.Drawing.Point(642, 395);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(188, 60);
            this.btnSaveChanges.TabIndex = 6;
            this.btnSaveChanges.Text = "Save changes";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "HH:mm";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(269, 152);
            this.timePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(75, 22);
            this.timePicker.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RosyBrown;
            this.label4.Location = new System.Drawing.Point(58, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Time:";
            // 
            // flowLayoutPreviewOutfit
            // 
            this.flowLayoutPreviewOutfit.AutoScroll = true;
            this.flowLayoutPreviewOutfit.BackColor = System.Drawing.Color.LavenderBlush;
            this.flowLayoutPreviewOutfit.ForeColor = System.Drawing.Color.RosyBrown;
            this.flowLayoutPreviewOutfit.Location = new System.Drawing.Point(53, 278);
            this.flowLayoutPreviewOutfit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPreviewOutfit.Name = "flowLayoutPreviewOutfit";
            this.flowLayoutPreviewOutfit.Size = new System.Drawing.Size(583, 178);
            this.flowLayoutPreviewOutfit.TabIndex = 10;
            this.flowLayoutPreviewOutfit.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPreviewOutfit_Paint);
            // 
            // UpdateEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::GlamLinkForm.Properties.Resources.iPiccy_img;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(852, 476);
            this.Controls.Add(this.flowLayoutPreviewOutfit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboOutfits);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEventName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UpdateEventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Event";
            this.Load += new System.EventHandler(this.UpdateEventForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.ComboBox comboOutfits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPreviewOutfit;
    }
}