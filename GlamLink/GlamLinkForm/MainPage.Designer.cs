using System.Drawing;

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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCloset = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.flowLayoutPanelClothes = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCategory_Shoes = new System.Windows.Forms.Button();
            this.btnCategory_Jackets = new System.Windows.Forms.Button();
            this.btnCategory_Acc = new System.Windows.Forms.Button();
            this.btnCategory_Bottoms = new System.Windows.Forms.Button();
            this.btnCategory_Tops = new System.Windows.Forms.Button();
            this.btnCategory_Dresses = new System.Windows.Forms.Button();
            this.tabOutfits = new System.Windows.Forms.TabPage();
            this.panelOutfitPreview = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEditOutfit = new System.Windows.Forms.Button();
            this.btnRefreshOutfits = new System.Windows.Forms.Button();
            this.btnDeleteOutfit = new System.Windows.Forms.Button();
            this.btnAddOutfit = new System.Windows.Forms.Button();
            this.listBoxOutfits = new System.Windows.Forms.ListBox();
            this.tabEvents = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.lblEventInfo = new System.Windows.Forms.Label();
            this.timePickerEvent = new System.Windows.Forms.DateTimePicker();
            this.flowPanelOutfit_Event = new System.Windows.Forms.FlowLayoutPanel();
            this.btnUpdateEvent = new System.Windows.Forms.Button();
            this.btnLoadEvents = new System.Windows.Forms.Button();
            this.btnDelEvent = new System.Windows.Forms.Button();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.calendarEvent = new System.Windows.Forms.MonthCalendar();
            this.tabComplaints = new System.Windows.Forms.TabPage();
            this.btnViewComplaints = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDomain = new System.Windows.Forms.ComboBox();
            this.btnSubmitComplaint = new System.Windows.Forms.Button();
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.labelVerifyInfo = new System.Windows.Forms.Label();
            this.labelOldUsername = new System.Windows.Forms.Label();
            this.textBoxOldUsername = new System.Windows.Forms.TextBox();
            this.textBoxOldPassword = new System.Windows.Forms.TextBox();
            this.textBoxNewUsername = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.labelOldPassword = new System.Windows.Forms.Label();
            this.btnVerifyCredentials = new System.Windows.Forms.Button();
            this.labelNewUsername = new System.Windows.Forms.Label();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabCloset.SuspendLayout();
            this.tabOutfits.SuspendLayout();
            this.tabEvents.SuspendLayout();
            this.tabComplaints.SuspendLayout();
            this.tabAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCloset);
            this.tabControl1.Controls.Add(this.tabOutfits);
            this.tabControl1.Controls.Add(this.tabEvents);
            this.tabControl1.Controls.Add(this.tabComplaints);
            this.tabControl1.Controls.Add(this.tabAccount);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Location = new System.Drawing.Point(0, 229);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1086, 585);
            this.tabControl1.TabIndex = 2;
            // 
            // tabCloset
            // 
            this.tabCloset.BackColor = System.Drawing.Color.MediumVioletRed;
            this.tabCloset.BackgroundImage = global::GlamLinkForm.Properties.Resources.luxa_org_opacity_changed___ipiccy_image__1___1___1_;
            this.tabCloset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabCloset.Controls.Add(this.btnDelete);
            this.tabCloset.Controls.Add(this.flowLayoutPanelClothes);
            this.tabCloset.Controls.Add(this.btnAdd);
            this.tabCloset.Controls.Add(this.btnCategory_Shoes);
            this.tabCloset.Controls.Add(this.btnCategory_Jackets);
            this.tabCloset.Controls.Add(this.btnCategory_Acc);
            this.tabCloset.Controls.Add(this.btnCategory_Bottoms);
            this.tabCloset.Controls.Add(this.btnCategory_Tops);
            this.tabCloset.Controls.Add(this.btnCategory_Dresses);
            this.tabCloset.ForeColor = System.Drawing.Color.Purple;
            this.tabCloset.Location = new System.Drawing.Point(4, 37);
            this.tabCloset.Name = "tabCloset";
            this.tabCloset.Padding = new System.Windows.Forms.Padding(3);
            this.tabCloset.Size = new System.Drawing.Size(1078, 544);
            this.tabCloset.TabIndex = 0;
            this.tabCloset.Text = "Closet";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnDelete.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnDelete.Location = new System.Drawing.Point(889, 228);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(154, 67);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Delete clothes";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // flowLayoutPanelClothes
            // 
            this.flowLayoutPanelClothes.AutoScroll = true;
            this.flowLayoutPanelClothes.BackColor = System.Drawing.Color.LavenderBlush;
            this.flowLayoutPanelClothes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelClothes.Location = new System.Drawing.Point(329, 33);
            this.flowLayoutPanelClothes.Name = "flowLayoutPanelClothes";
            this.flowLayoutPanelClothes.Size = new System.Drawing.Size(525, 291);
            this.flowLayoutPanelClothes.TabIndex = 28;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnAdd.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnAdd.Location = new System.Drawing.Point(889, 64);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(154, 67);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "Add clothes";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCategory_Shoes
            // 
            this.btnCategory_Shoes.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnCategory_Shoes.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnCategory_Shoes.Location = new System.Drawing.Point(99, 228);
            this.btnCategory_Shoes.Name = "btnCategory_Shoes";
            this.btnCategory_Shoes.Size = new System.Drawing.Size(166, 45);
            this.btnCategory_Shoes.TabIndex = 26;
            this.btnCategory_Shoes.Text = "Shoes";
            this.btnCategory_Shoes.UseVisualStyleBackColor = false;
            this.btnCategory_Shoes.Click += new System.EventHandler(this.btnCategory_Shoes_Click);
            // 
            // btnCategory_Jackets
            // 
            this.btnCategory_Jackets.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnCategory_Jackets.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnCategory_Jackets.Location = new System.Drawing.Point(99, 177);
            this.btnCategory_Jackets.Name = "btnCategory_Jackets";
            this.btnCategory_Jackets.Size = new System.Drawing.Size(166, 45);
            this.btnCategory_Jackets.TabIndex = 25;
            this.btnCategory_Jackets.Text = "Jackets";
            this.btnCategory_Jackets.UseVisualStyleBackColor = false;
            this.btnCategory_Jackets.Click += new System.EventHandler(this.btnCategory_Jackets_Click);
            // 
            // btnCategory_Acc
            // 
            this.btnCategory_Acc.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnCategory_Acc.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnCategory_Acc.Location = new System.Drawing.Point(99, 279);
            this.btnCategory_Acc.Name = "btnCategory_Acc";
            this.btnCategory_Acc.Size = new System.Drawing.Size(166, 45);
            this.btnCategory_Acc.TabIndex = 24;
            this.btnCategory_Acc.Text = "Accessories";
            this.btnCategory_Acc.UseVisualStyleBackColor = false;
            this.btnCategory_Acc.Click += new System.EventHandler(this.btnCategory_Acc_Click);
            // 
            // btnCategory_Bottoms
            // 
            this.btnCategory_Bottoms.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnCategory_Bottoms.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnCategory_Bottoms.Location = new System.Drawing.Point(99, 126);
            this.btnCategory_Bottoms.Name = "btnCategory_Bottoms";
            this.btnCategory_Bottoms.Size = new System.Drawing.Size(166, 45);
            this.btnCategory_Bottoms.TabIndex = 23;
            this.btnCategory_Bottoms.Text = "Bottoms";
            this.btnCategory_Bottoms.UseVisualStyleBackColor = false;
            this.btnCategory_Bottoms.Click += new System.EventHandler(this.btnCategory_Bottoms_Click);
            // 
            // btnCategory_Tops
            // 
            this.btnCategory_Tops.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnCategory_Tops.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnCategory_Tops.Location = new System.Drawing.Point(99, 75);
            this.btnCategory_Tops.Name = "btnCategory_Tops";
            this.btnCategory_Tops.Size = new System.Drawing.Size(166, 45);
            this.btnCategory_Tops.TabIndex = 22;
            this.btnCategory_Tops.Text = "Tops";
            this.btnCategory_Tops.UseVisualStyleBackColor = false;
            this.btnCategory_Tops.Click += new System.EventHandler(this.btnCategory_Tops_Click);
            // 
            // btnCategory_Dresses
            // 
            this.btnCategory_Dresses.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnCategory_Dresses.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnCategory_Dresses.Location = new System.Drawing.Point(99, 24);
            this.btnCategory_Dresses.Name = "btnCategory_Dresses";
            this.btnCategory_Dresses.Size = new System.Drawing.Size(166, 45);
            this.btnCategory_Dresses.TabIndex = 21;
            this.btnCategory_Dresses.Text = "Dresses";
            this.btnCategory_Dresses.UseVisualStyleBackColor = false;
            this.btnCategory_Dresses.Click += new System.EventHandler(this.btnCategory_Dresses_Click);
            // 
            // tabOutfits
            // 
            this.tabOutfits.BackColor = System.Drawing.Color.MediumVioletRed;
            this.tabOutfits.BackgroundImage = global::GlamLinkForm.Properties.Resources.luxa_org_opacity_changed___ipiccy_image__1___1___1_;
            this.tabOutfits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabOutfits.Controls.Add(this.panelOutfitPreview);
            this.tabOutfits.Controls.Add(this.btnEditOutfit);
            this.tabOutfits.Controls.Add(this.btnRefreshOutfits);
            this.tabOutfits.Controls.Add(this.btnDeleteOutfit);
            this.tabOutfits.Controls.Add(this.btnAddOutfit);
            this.tabOutfits.Controls.Add(this.listBoxOutfits);
            this.tabOutfits.Location = new System.Drawing.Point(4, 25);
            this.tabOutfits.Name = "tabOutfits";
            this.tabOutfits.Padding = new System.Windows.Forms.Padding(3);
            this.tabOutfits.Size = new System.Drawing.Size(1078, 556);
            this.tabOutfits.TabIndex = 1;
            this.tabOutfits.Text = "Outfits";
            // 
            // panelOutfitPreview
            // 
            this.panelOutfitPreview.AutoScroll = true;
            this.panelOutfitPreview.BackColor = System.Drawing.Color.LavenderBlush;
            this.panelOutfitPreview.Location = new System.Drawing.Point(604, 43);
            this.panelOutfitPreview.Name = "panelOutfitPreview";
            this.panelOutfitPreview.Size = new System.Drawing.Size(401, 308);
            this.panelOutfitPreview.TabIndex = 6;
            // 
            // btnEditOutfit
            // 
            this.btnEditOutfit.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnEditOutfit.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnEditOutfit.Location = new System.Drawing.Point(402, 218);
            this.btnEditOutfit.Name = "btnEditOutfit";
            this.btnEditOutfit.Size = new System.Drawing.Size(165, 48);
            this.btnEditOutfit.TabIndex = 5;
            this.btnEditOutfit.Text = "Edit outfit";
            this.btnEditOutfit.UseVisualStyleBackColor = false;
            this.btnEditOutfit.Click += new System.EventHandler(this.btnEditOutfit_Click);
            // 
            // btnRefreshOutfits
            // 
            this.btnRefreshOutfits.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnRefreshOutfits.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnRefreshOutfits.Location = new System.Drawing.Point(402, 294);
            this.btnRefreshOutfits.Name = "btnRefreshOutfits";
            this.btnRefreshOutfits.Size = new System.Drawing.Size(165, 48);
            this.btnRefreshOutfits.TabIndex = 4;
            this.btnRefreshOutfits.Text = "Refresh";
            this.btnRefreshOutfits.UseVisualStyleBackColor = false;
            this.btnRefreshOutfits.Click += new System.EventHandler(this.btnRefreshOutfits_Click);
            // 
            // btnDeleteOutfit
            // 
            this.btnDeleteOutfit.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnDeleteOutfit.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnDeleteOutfit.Location = new System.Drawing.Point(402, 146);
            this.btnDeleteOutfit.Name = "btnDeleteOutfit";
            this.btnDeleteOutfit.Size = new System.Drawing.Size(165, 48);
            this.btnDeleteOutfit.TabIndex = 3;
            this.btnDeleteOutfit.Text = "Delete outfit";
            this.btnDeleteOutfit.UseVisualStyleBackColor = false;
            this.btnDeleteOutfit.Click += new System.EventHandler(this.btnDeleteOutfit_Click);
            // 
            // btnAddOutfit
            // 
            this.btnAddOutfit.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnAddOutfit.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnAddOutfit.Location = new System.Drawing.Point(402, 68);
            this.btnAddOutfit.Name = "btnAddOutfit";
            this.btnAddOutfit.Size = new System.Drawing.Size(165, 48);
            this.btnAddOutfit.TabIndex = 2;
            this.btnAddOutfit.Text = "Add outfit";
            this.btnAddOutfit.UseVisualStyleBackColor = false;
            this.btnAddOutfit.Click += new System.EventHandler(this.btnAddOutfit_Click);
            // 
            // listBoxOutfits
            // 
            this.listBoxOutfits.BackColor = System.Drawing.Color.LavenderBlush;
            this.listBoxOutfits.ForeColor = System.Drawing.Color.RosyBrown;
            this.listBoxOutfits.FormattingEnabled = true;
            this.listBoxOutfits.ItemHeight = 28;
            this.listBoxOutfits.Location = new System.Drawing.Point(132, 67);
            this.listBoxOutfits.Name = "listBoxOutfits";
            this.listBoxOutfits.Size = new System.Drawing.Size(232, 284);
            this.listBoxOutfits.TabIndex = 0;
            this.listBoxOutfits.SelectedIndexChanged += new System.EventHandler(this.listBoxOutfits_SelectedIndexChanged);
            // 
            // tabEvents
            // 
            this.tabEvents.BackColor = System.Drawing.Color.MediumVioletRed;
            this.tabEvents.BackgroundImage = global::GlamLinkForm.Properties.Resources.luxa_org_opacity_changed___ipiccy_image__1___1___1_;
            this.tabEvents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabEvents.Controls.Add(this.label6);
            this.tabEvents.Controls.Add(this.listBoxEvents);
            this.tabEvents.Controls.Add(this.lblEventInfo);
            this.tabEvents.Controls.Add(this.timePickerEvent);
            this.tabEvents.Controls.Add(this.flowPanelOutfit_Event);
            this.tabEvents.Controls.Add(this.btnUpdateEvent);
            this.tabEvents.Controls.Add(this.btnLoadEvents);
            this.tabEvents.Controls.Add(this.btnDelEvent);
            this.tabEvents.Controls.Add(this.btnAddEvent);
            this.tabEvents.Controls.Add(this.calendarEvent);
            this.tabEvents.Location = new System.Drawing.Point(4, 25);
            this.tabEvents.Name = "tabEvents";
            this.tabEvents.Size = new System.Drawing.Size(1078, 556);
            this.tabEvents.TabIndex = 2;
            this.tabEvents.Text = "Events";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LavenderBlush;
            this.label6.ForeColor = System.Drawing.Color.RosyBrown;
            this.label6.Location = new System.Drawing.Point(425, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "Event time:";
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.BackColor = System.Drawing.Color.LavenderBlush;
            this.listBoxEvents.ForeColor = System.Drawing.Color.RosyBrown;
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 28;
            this.listBoxEvents.Location = new System.Drawing.Point(186, 247);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(450, 116);
            this.listBoxEvents.TabIndex = 8;
            this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
            // 
            // lblEventInfo
            // 
            this.lblEventInfo.AutoSize = true;
            this.lblEventInfo.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblEventInfo.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblEventInfo.Location = new System.Drawing.Point(191, 376);
            this.lblEventInfo.Name = "lblEventInfo";
            this.lblEventInfo.Size = new System.Drawing.Size(184, 28);
            this.lblEventInfo.TabIndex = 4;
            this.lblEventInfo.Text = "Event Information";
            // 
            // timePickerEvent
            // 
            this.timePickerEvent.CalendarFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePickerEvent.CalendarForeColor = System.Drawing.Color.HotPink;
            this.timePickerEvent.CalendarMonthBackground = System.Drawing.Color.LightBlue;
            this.timePickerEvent.CalendarTitleForeColor = System.Drawing.Color.RosyBrown;
            this.timePickerEvent.CalendarTrailingForeColor = System.Drawing.Color.LavenderBlush;
            this.timePickerEvent.CustomFormat = "HH:mm";
            this.timePickerEvent.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePickerEvent.Location = new System.Drawing.Point(418, 157);
            this.timePickerEvent.Name = "timePickerEvent";
            this.timePickerEvent.ShowUpDown = true;
            this.timePickerEvent.Size = new System.Drawing.Size(111, 34);
            this.timePickerEvent.TabIndex = 7;
            // 
            // flowPanelOutfit_Event
            // 
            this.flowPanelOutfit_Event.AutoScroll = true;
            this.flowPanelOutfit_Event.BackColor = System.Drawing.Color.LavenderBlush;
            this.flowPanelOutfit_Event.Enabled = false;
            this.flowPanelOutfit_Event.Location = new System.Drawing.Point(755, 27);
            this.flowPanelOutfit_Event.Name = "flowPanelOutfit_Event";
            this.flowPanelOutfit_Event.Size = new System.Drawing.Size(253, 439);
            this.flowPanelOutfit_Event.TabIndex = 6;
            // 
            // btnUpdateEvent
            // 
            this.btnUpdateEvent.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnUpdateEvent.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnUpdateEvent.Location = new System.Drawing.Point(560, 157);
            this.btnUpdateEvent.Name = "btnUpdateEvent";
            this.btnUpdateEvent.Size = new System.Drawing.Size(159, 41);
            this.btnUpdateEvent.TabIndex = 5;
            this.btnUpdateEvent.Text = "Update event";
            this.btnUpdateEvent.UseVisualStyleBackColor = false;
            this.btnUpdateEvent.Click += new System.EventHandler(this.btnUpdateEvent_Click);
            // 
            // btnLoadEvents
            // 
            this.btnLoadEvents.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnLoadEvents.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnLoadEvents.Location = new System.Drawing.Point(186, 211);
            this.btnLoadEvents.Name = "btnLoadEvents";
            this.btnLoadEvents.Size = new System.Drawing.Size(202, 30);
            this.btnLoadEvents.TabIndex = 3;
            this.btnLoadEvents.Text = "Load my events";
            this.btnLoadEvents.UseVisualStyleBackColor = false;
            this.btnLoadEvents.Click += new System.EventHandler(this.btnLoadEvents_Click);
            // 
            // btnDelEvent
            // 
            this.btnDelEvent.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnDelEvent.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnDelEvent.Location = new System.Drawing.Point(560, 94);
            this.btnDelEvent.Name = "btnDelEvent";
            this.btnDelEvent.Size = new System.Drawing.Size(159, 41);
            this.btnDelEvent.TabIndex = 2;
            this.btnDelEvent.Text = "Delete event";
            this.btnDelEvent.UseVisualStyleBackColor = false;
            this.btnDelEvent.Click += new System.EventHandler(this.btnDelEvent_Click);
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnAddEvent.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnAddEvent.Location = new System.Drawing.Point(560, 27);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(159, 41);
            this.btnAddEvent.TabIndex = 1;
            this.btnAddEvent.Text = "Add event";
            this.btnAddEvent.UseVisualStyleBackColor = false;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // calendarEvent
            // 
            this.calendarEvent.BackColor = System.Drawing.Color.LavenderBlush;
            this.calendarEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarEvent.ForeColor = System.Drawing.Color.RosyBrown;
            this.calendarEvent.Location = new System.Drawing.Point(186, 27);
            this.calendarEvent.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.calendarEvent.Name = "calendarEvent";
            this.calendarEvent.TabIndex = 0;
            this.calendarEvent.TitleBackColor = System.Drawing.Color.Moccasin;
            this.calendarEvent.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendarEvent_DateSelected);
            // 
            // tabComplaints
            // 
            this.tabComplaints.BackColor = System.Drawing.Color.MediumVioletRed;
            this.tabComplaints.BackgroundImage = global::GlamLinkForm.Properties.Resources.luxa_org_opacity_changed___ipiccy_image__1___1___1_;
            this.tabComplaints.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabComplaints.Controls.Add(this.btnViewComplaints);
            this.tabComplaints.Controls.Add(this.label4);
            this.tabComplaints.Controls.Add(this.txtDomain);
            this.tabComplaints.Controls.Add(this.txtSubject);
            this.tabComplaints.Controls.Add(this.label1);
            this.tabComplaints.Controls.Add(this.label3);
            this.tabComplaints.Controls.Add(this.label2);
            this.tabComplaints.Controls.Add(this.comboBoxDomain);
            this.tabComplaints.Controls.Add(this.btnSubmitComplaint);
            this.tabComplaints.Location = new System.Drawing.Point(4, 25);
            this.tabComplaints.Name = "tabComplaints";
            this.tabComplaints.Size = new System.Drawing.Size(1078, 556);
            this.tabComplaints.TabIndex = 3;
            this.tabComplaints.Text = "Complaints";
            // 
            // btnViewComplaints
            // 
            this.btnViewComplaints.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnViewComplaints.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnViewComplaints.Location = new System.Drawing.Point(91, 331);
            this.btnViewComplaints.Name = "btnViewComplaints";
            this.btnViewComplaints.Size = new System.Drawing.Size(223, 63);
            this.btnViewComplaints.TabIndex = 16;
            this.btnViewComplaints.Text = "View my complaints";
            this.btnViewComplaints.UseVisualStyleBackColor = false;
            this.btnViewComplaints.Click += new System.EventHandler(this.btnViewComplaints_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LavenderBlush;
            this.label4.ForeColor = System.Drawing.Color.RosyBrown;
            this.label4.Location = new System.Drawing.Point(342, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Choose the problem domain:";
            // 
            // txtDomain
            // 
            this.txtDomain.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtDomain.ForeColor = System.Drawing.Color.RosyBrown;
            this.txtDomain.Location = new System.Drawing.Point(347, 199);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(465, 34);
            this.txtDomain.TabIndex = 9;
            // 
            // txtSubject
            // 
            this.txtSubject.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtSubject.ForeColor = System.Drawing.Color.RosyBrown;
            this.txtSubject.Location = new System.Drawing.Point(347, 111);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(212, 34);
            this.txtSubject.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LavenderBlush;
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(342, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Description:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LavenderBlush;
            this.label3.ForeColor = System.Drawing.Color.RosyBrown;
            this.label3.Location = new System.Drawing.Point(342, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Subject:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LavenderBlush;
            this.label2.ForeColor = System.Drawing.Color.RosyBrown;
            this.label2.Location = new System.Drawing.Point(342, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(443, 27);
            this.label2.TabIndex = 13;
            this.label2.Text = "Let us know how we can improve your user experience";
            // 
            // comboBoxDomain
            // 
            this.comboBoxDomain.BackColor = System.Drawing.Color.LavenderBlush;
            this.comboBoxDomain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDomain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDomain.ForeColor = System.Drawing.Color.RosyBrown;
            this.comboBoxDomain.FormattingEnabled = true;
            this.comboBoxDomain.Items.AddRange(new object[] {
            "Something is not working properly",
            "Something looks strange on the screen",
            "The app is too slow",
            "Other issue or suggestion"});
            this.comboBoxDomain.Location = new System.Drawing.Point(347, 289);
            this.comboBoxDomain.Name = "comboBoxDomain";
            this.comboBoxDomain.Size = new System.Drawing.Size(300, 36);
            this.comboBoxDomain.TabIndex = 14;
            // 
            // btnSubmitComplaint
            // 
            this.btnSubmitComplaint.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSubmitComplaint.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnSubmitComplaint.Location = new System.Drawing.Point(789, 331);
            this.btnSubmitComplaint.Name = "btnSubmitComplaint";
            this.btnSubmitComplaint.Size = new System.Drawing.Size(223, 63);
            this.btnSubmitComplaint.TabIndex = 15;
            this.btnSubmitComplaint.Text = "Send Complaint";
            this.btnSubmitComplaint.UseVisualStyleBackColor = false;
            this.btnSubmitComplaint.Click += new System.EventHandler(this.btnSubmitComplaint_Click);
            // 
            // tabAccount
            // 
            this.tabAccount.BackColor = System.Drawing.Color.LavenderBlush;
            this.tabAccount.BackgroundImage = global::GlamLinkForm.Properties.Resources.luxa_org_opacity_changed___ipiccy_image__1___1___1_;
            this.tabAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabAccount.Controls.Add(this.label5);
            this.tabAccount.Controls.Add(this.labelVerifyInfo);
            this.tabAccount.Controls.Add(this.labelOldUsername);
            this.tabAccount.Controls.Add(this.textBoxOldUsername);
            this.tabAccount.Controls.Add(this.textBoxOldPassword);
            this.tabAccount.Controls.Add(this.textBoxNewUsername);
            this.tabAccount.Controls.Add(this.textBoxNewPassword);
            this.tabAccount.Controls.Add(this.labelOldPassword);
            this.tabAccount.Controls.Add(this.btnVerifyCredentials);
            this.tabAccount.Controls.Add(this.labelNewUsername);
            this.tabAccount.Controls.Add(this.labelNewPassword);
            this.tabAccount.Controls.Add(this.btnUpdateAccount);
            this.tabAccount.Controls.Add(this.btnLogout);
            this.tabAccount.ForeColor = System.Drawing.Color.RosyBrown;
            this.tabAccount.Location = new System.Drawing.Point(4, 25);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Size = new System.Drawing.Size(1078, 556);
            this.tabAccount.TabIndex = 4;
            this.tabAccount.Text = "Account";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LavenderBlush;
            this.label5.ForeColor = System.Drawing.Color.RosyBrown;
            this.label5.Location = new System.Drawing.Point(236, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(676, 28);
            this.label5.TabIndex = 24;
            this.label5.Text = "Please confirm your credentials before trying to update your account:";
            // 
            // labelVerifyInfo
            // 
            this.labelVerifyInfo.BackColor = System.Drawing.Color.LavenderBlush;
            this.labelVerifyInfo.ForeColor = System.Drawing.Color.RosyBrown;
            this.labelVerifyInfo.Location = new System.Drawing.Point(315, 15);
            this.labelVerifyInfo.Name = "labelVerifyInfo";
            this.labelVerifyInfo.Size = new System.Drawing.Size(494, 22);
            this.labelVerifyInfo.TabIndex = 12;
            this.labelVerifyInfo.Text = "Confirm your credentials before updating your credentials:";
            // 
            // labelOldUsername
            // 
            this.labelOldUsername.BackColor = System.Drawing.Color.LavenderBlush;
            this.labelOldUsername.ForeColor = System.Drawing.Color.RosyBrown;
            this.labelOldUsername.Location = new System.Drawing.Point(341, 63);
            this.labelOldUsername.Name = "labelOldUsername";
            this.labelOldUsername.Size = new System.Drawing.Size(100, 23);
            this.labelOldUsername.TabIndex = 13;
            this.labelOldUsername.Text = "Username:";
            // 
            // textBoxOldUsername
            // 
            this.textBoxOldUsername.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBoxOldUsername.ForeColor = System.Drawing.Color.RosyBrown;
            this.textBoxOldUsername.Location = new System.Drawing.Point(470, 60);
            this.textBoxOldUsername.Name = "textBoxOldUsername";
            this.textBoxOldUsername.Size = new System.Drawing.Size(200, 34);
            this.textBoxOldUsername.TabIndex = 14;
            // 
            // textBoxOldPassword
            // 
            this.textBoxOldPassword.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBoxOldPassword.ForeColor = System.Drawing.Color.RosyBrown;
            this.textBoxOldPassword.Location = new System.Drawing.Point(470, 108);
            this.textBoxOldPassword.Name = "textBoxOldPassword";
            this.textBoxOldPassword.PasswordChar = '*';
            this.textBoxOldPassword.Size = new System.Drawing.Size(200, 34);
            this.textBoxOldPassword.TabIndex = 16;
            // 
            // textBoxNewUsername
            // 
            this.textBoxNewUsername.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBoxNewUsername.Enabled = false;
            this.textBoxNewUsername.ForeColor = System.Drawing.Color.RosyBrown;
            this.textBoxNewUsername.Location = new System.Drawing.Point(470, 262);
            this.textBoxNewUsername.Name = "textBoxNewUsername";
            this.textBoxNewUsername.Size = new System.Drawing.Size(200, 34);
            this.textBoxNewUsername.TabIndex = 19;
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBoxNewPassword.Enabled = false;
            this.textBoxNewPassword.ForeColor = System.Drawing.Color.RosyBrown;
            this.textBoxNewPassword.Location = new System.Drawing.Point(470, 317);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.PasswordChar = '*';
            this.textBoxNewPassword.Size = new System.Drawing.Size(200, 34);
            this.textBoxNewPassword.TabIndex = 21;
            // 
            // labelOldPassword
            // 
            this.labelOldPassword.BackColor = System.Drawing.Color.LavenderBlush;
            this.labelOldPassword.ForeColor = System.Drawing.Color.RosyBrown;
            this.labelOldPassword.Location = new System.Drawing.Point(347, 111);
            this.labelOldPassword.Name = "labelOldPassword";
            this.labelOldPassword.Size = new System.Drawing.Size(100, 23);
            this.labelOldPassword.TabIndex = 15;
            this.labelOldPassword.Text = "Password:";
            // 
            // btnVerifyCredentials
            // 
            this.btnVerifyCredentials.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnVerifyCredentials.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnVerifyCredentials.Location = new System.Drawing.Point(470, 158);
            this.btnVerifyCredentials.Name = "btnVerifyCredentials";
            this.btnVerifyCredentials.Size = new System.Drawing.Size(192, 44);
            this.btnVerifyCredentials.TabIndex = 17;
            this.btnVerifyCredentials.Text = "Verify";
            this.btnVerifyCredentials.UseVisualStyleBackColor = false;
            this.btnVerifyCredentials.Click += new System.EventHandler(this.btnVerifyCredentials_Click);
            // 
            // labelNewUsername
            // 
            this.labelNewUsername.BackColor = System.Drawing.Color.LavenderBlush;
            this.labelNewUsername.Enabled = false;
            this.labelNewUsername.ForeColor = System.Drawing.Color.RosyBrown;
            this.labelNewUsername.Location = new System.Drawing.Point(315, 265);
            this.labelNewUsername.Name = "labelNewUsername";
            this.labelNewUsername.Size = new System.Drawing.Size(132, 23);
            this.labelNewUsername.TabIndex = 18;
            this.labelNewUsername.Text = "New Username:";
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.BackColor = System.Drawing.Color.LavenderBlush;
            this.labelNewPassword.ForeColor = System.Drawing.Color.RosyBrown;
            this.labelNewPassword.Location = new System.Drawing.Point(315, 320);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(132, 23);
            this.labelNewPassword.TabIndex = 20;
            this.labelNewPassword.Text = "New Password:";
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnUpdateAccount.Enabled = false;
            this.btnUpdateAccount.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnUpdateAccount.Location = new System.Drawing.Point(470, 357);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(192, 44);
            this.btnUpdateAccount.TabIndex = 22;
            this.btnUpdateAccount.Text = "Update Account";
            this.btnUpdateAccount.UseVisualStyleBackColor = false;
            this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnLogout.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnLogout.Location = new System.Drawing.Point(749, 423);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(163, 44);
            this.btnLogout.TabIndex = 23;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Pink;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 229);
            this.panel1.TabIndex = 0;
            // 
            // MainPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1099, 675);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Purple;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GlamLink";
            this.tabControl1.ResumeLayout(false);
            this.tabCloset.ResumeLayout(false);
            this.tabOutfits.ResumeLayout(false);
            this.tabEvents.ResumeLayout(false);
            this.tabEvents.PerformLayout();
            this.tabComplaints.ResumeLayout(false);
            this.tabComplaints.PerformLayout();
            this.tabAccount.ResumeLayout(false);
            this.tabAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabAccount;
        private System.Windows.Forms.Label labelVerifyInfo;
        private System.Windows.Forms.Label labelOldUsername;
        private System.Windows.Forms.TextBox textBoxOldUsername;
        private System.Windows.Forms.TextBox textBoxOldPassword;
        private System.Windows.Forms.TextBox textBoxNewUsername;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Label labelOldPassword;
        private System.Windows.Forms.Button btnVerifyCredentials;
        private System.Windows.Forms.Label labelNewUsername;
        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.Button btnUpdateAccount;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabPage tabComplaints;
        private System.Windows.Forms.Button btnViewComplaints;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDomain;
        private System.Windows.Forms.Button btnSubmitComplaint;
        private System.Windows.Forms.TabPage tabEvents;
        private System.Windows.Forms.DateTimePicker timePickerEvent;
        private System.Windows.Forms.FlowLayoutPanel flowPanelOutfit_Event;
        private System.Windows.Forms.Button btnUpdateEvent;
        private System.Windows.Forms.Label lblEventInfo;
        private System.Windows.Forms.Button btnLoadEvents;
        private System.Windows.Forms.Button btnDelEvent;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.MonthCalendar calendarEvent;
        private System.Windows.Forms.TabPage tabOutfits;
        private System.Windows.Forms.FlowLayoutPanel panelOutfitPreview;
        private System.Windows.Forms.Button btnEditOutfit;
        private System.Windows.Forms.Button btnRefreshOutfits;
        private System.Windows.Forms.Button btnDeleteOutfit;
        private System.Windows.Forms.Button btnAddOutfit;
        private System.Windows.Forms.ListBox listBoxOutfits;
        private System.Windows.Forms.TabPage tabCloset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelClothes;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCategory_Shoes;
        private System.Windows.Forms.Button btnCategory_Jackets;
        private System.Windows.Forms.Button btnCategory_Acc;
        private System.Windows.Forms.Button btnCategory_Bottoms;
        private System.Windows.Forms.Button btnCategory_Tops;
        private System.Windows.Forms.Button btnCategory_Dresses;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

