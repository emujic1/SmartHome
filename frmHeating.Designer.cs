namespace SmartHome
{
    partial class frmHeating
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHeating));
            this.splitter1 = new Kesoft.Windows.Forms.Panels.Splitter();
            this.btnEconomy = new MetroFramework.Controls.MetroButton();
            this.btnCustom = new MetroFramework.Controls.MetroButton();
            this.btnColingOff = new MetroFramework.Controls.MetroButton();
            this.ButtonShedule = new MetroFramework.Controls.MetroButton();
            this.ButtonBack = new MetroFramework.Controls.MetroButton();
            this.btnAuto = new MetroFramework.Controls.MetroButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.kidsRoomValue = new System.Windows.Forms.Label();
            this.metroScrollKidsBedRoom = new MetroFramework.Controls.MetroScrollBar();
            this.metroToggleKidsBedRoom = new MetroFramework.Controls.MetroToggle();
            this.panel5 = new System.Windows.Forms.Panel();
            this.diningRoomValue = new System.Windows.Forms.Label();
            this.metroToggleDiningRoom = new MetroFramework.Controls.MetroToggle();
            this.metroScrollDiningRoom = new MetroFramework.Controls.MetroScrollBar();
            this.panel6 = new System.Windows.Forms.Panel();
            this.bathRoomValue = new System.Windows.Forms.Label();
            this.metroScrollBathroom = new MetroFramework.Controls.MetroScrollBar();
            this.metroToggleBathroom = new MetroFramework.Controls.MetroToggle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bedRoomValue = new System.Windows.Forms.Label();
            this.metroToggleBedRoom = new MetroFramework.Controls.MetroToggle();
            this.metroScrollBedRoom = new MetroFramework.Controls.MetroScrollBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.kitchenValue = new System.Windows.Forms.Label();
            this.metroScrollKichen = new MetroFramework.Controls.MetroScrollBar();
            this.KichenToggle = new MetroFramework.Controls.MetroToggle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.livRoomValue = new System.Windows.Forms.Label();
            this.metroScrollLiving = new MetroFramework.Controls.MetroScrollBar();
            this.LivingRoomToggle = new MetroFramework.Controls.MetroToggle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Transparent;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 512);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // btnEconomy
            // 
            this.btnEconomy.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEconomy.Location = new System.Drawing.Point(37, 100);
            this.btnEconomy.Name = "btnEconomy";
            this.btnEconomy.Size = new System.Drawing.Size(99, 42);
            this.btnEconomy.TabIndex = 7;
            this.btnEconomy.Text = "Economy";
            this.btnEconomy.UseCustomBackColor = true;
            this.btnEconomy.UseSelectable = true;
            this.btnEconomy.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnCustom
            // 
            this.btnCustom.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCustom.Location = new System.Drawing.Point(37, 282);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(99, 42);
            this.btnCustom.TabIndex = 9;
            this.btnCustom.Text = "Custom";
            this.btnCustom.UseCustomBackColor = true;
            this.btnCustom.UseSelectable = true;
            this.btnCustom.Click += new System.EventHandler(this.ButtonCustom_Click);
            // 
            // btnColingOff
            // 
            this.btnColingOff.BackColor = System.Drawing.Color.Gainsboro;
            this.btnColingOff.Location = new System.Drawing.Point(37, 370);
            this.btnColingOff.Name = "btnColingOff";
            this.btnColingOff.Size = new System.Drawing.Size(99, 42);
            this.btnColingOff.TabIndex = 10;
            this.btnColingOff.Text = "Cooling off";
            this.btnColingOff.UseCustomBackColor = true;
            this.btnColingOff.UseSelectable = true;
            this.btnColingOff.Click += new System.EventHandler(this.ButtonColingOff_Click);
            // 
            // ButtonShedule
            // 
            this.ButtonShedule.BackColor = System.Drawing.Color.Gainsboro;
            this.ButtonShedule.Location = new System.Drawing.Point(403, 445);
            this.ButtonShedule.Name = "ButtonShedule";
            this.ButtonShedule.Size = new System.Drawing.Size(206, 42);
            this.ButtonShedule.TabIndex = 11;
            this.ButtonShedule.Text = "Shedule";
            this.ButtonShedule.UseCustomForeColor = true;
            this.ButtonShedule.UseSelectable = true;
            this.ButtonShedule.Click += new System.EventHandler(this.ButtonShedule_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.BackColor = System.Drawing.Color.Gainsboro;
            this.ButtonBack.Location = new System.Drawing.Point(12, 12);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(83, 29);
            this.ButtonBack.TabIndex = 12;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseCustomBackColor = true;
            this.ButtonBack.UseSelectable = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAuto.Location = new System.Drawing.Point(37, 189);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(99, 42);
            this.btnAuto.TabIndex = 22;
            this.btnAuto.Text = "Auto";
            this.btnAuto.UseCustomBackColor = true;
            this.btnAuto.UseSelectable = true;
            this.btnAuto.Click += new System.EventHandler(this.ButtonAuto_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::SmartHome.Properties.Resources.KidsBedRoom;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.kidsRoomValue);
            this.panel3.Controls.Add(this.metroScrollKidsBedRoom);
            this.panel3.Controls.Add(this.metroToggleKidsBedRoom);
            this.panel3.Location = new System.Drawing.Point(630, 252);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 160);
            this.panel3.TabIndex = 5;
            // 
            // kidsRoomValue
            // 
            this.kidsRoomValue.AutoSize = true;
            this.kidsRoomValue.BackColor = System.Drawing.Color.Transparent;
            this.kidsRoomValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kidsRoomValue.ForeColor = System.Drawing.Color.White;
            this.kidsRoomValue.Location = new System.Drawing.Point(68, 66);
            this.kidsRoomValue.Name = "kidsRoomValue";
            this.kidsRoomValue.Size = new System.Drawing.Size(87, 31);
            this.kidsRoomValue.TabIndex = 15;
            this.kidsRoomValue.Text = "12 °C";
            this.kidsRoomValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroScrollKidsBedRoom
            // 
            this.metroScrollKidsBedRoom.AccessibleDescription = "";
            this.metroScrollKidsBedRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroScrollKidsBedRoom.LargeChange = 10;
            this.metroScrollKidsBedRoom.Location = new System.Drawing.Point(5, 140);
            this.metroScrollKidsBedRoom.Maximum = 35;
            this.metroScrollKidsBedRoom.Minimum = 10;
            this.metroScrollKidsBedRoom.MouseWheelBarPartitions = 2;
            this.metroScrollKidsBedRoom.Name = "metroScrollKidsBedRoom";
            this.metroScrollKidsBedRoom.Orientation = MetroFramework.Controls.MetroScrollOrientation.Horizontal;
            this.metroScrollKidsBedRoom.ScrollbarSize = 15;
            this.metroScrollKidsBedRoom.Size = new System.Drawing.Size(200, 15);
            this.metroScrollKidsBedRoom.SmallChange = 2;
            this.metroScrollKidsBedRoom.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroScrollKidsBedRoom.TabIndex = 11;
            this.metroScrollKidsBedRoom.Tag = "";
            this.metroScrollKidsBedRoom.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroScrollKidsBedRoom.UseCustomBackColor = true;
            this.metroScrollKidsBedRoom.UseSelectable = true;
            this.metroScrollKidsBedRoom.Value = 10;
            this.metroScrollKidsBedRoom.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroScrollKidsBedRoom_Scroll);
            // 
            // metroToggleKidsBedRoom
            // 
            this.metroToggleKidsBedRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroToggleKidsBedRoom.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroToggleKidsBedRoom.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.metroToggleKidsBedRoom.Location = new System.Drawing.Point(67, 3);
            this.metroToggleKidsBedRoom.Name = "metroToggleKidsBedRoom";
            this.metroToggleKidsBedRoom.Size = new System.Drawing.Size(88, 25);
            this.metroToggleKidsBedRoom.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroToggleKidsBedRoom.TabIndex = 12;
            this.metroToggleKidsBedRoom.Text = "Off";
            this.metroToggleKidsBedRoom.UseSelectable = true;
            this.metroToggleKidsBedRoom.CheckStateChanged += new System.EventHandler(this.metroToggleKidsBedRoom_CheckStateChanged);
            this.metroToggleKidsBedRoom.Click += new System.EventHandler(this.metroToggleBathroom_Click);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::SmartHome.Properties.Resources.diningroom_main;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.diningRoomValue);
            this.panel5.Controls.Add(this.metroToggleDiningRoom);
            this.panel5.Controls.Add(this.metroScrollDiningRoom);
            this.panel5.Location = new System.Drawing.Point(403, 252);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(210, 160);
            this.panel5.TabIndex = 4;
            // 
            // diningRoomValue
            // 
            this.diningRoomValue.AutoSize = true;
            this.diningRoomValue.BackColor = System.Drawing.Color.Transparent;
            this.diningRoomValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.diningRoomValue.ForeColor = System.Drawing.Color.White;
            this.diningRoomValue.Location = new System.Drawing.Point(67, 66);
            this.diningRoomValue.Name = "diningRoomValue";
            this.diningRoomValue.Size = new System.Drawing.Size(87, 31);
            this.diningRoomValue.TabIndex = 17;
            this.diningRoomValue.Text = "12 °C";
            this.diningRoomValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroToggleDiningRoom
            // 
            this.metroToggleDiningRoom.Checked = true;
            this.metroToggleDiningRoom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroToggleDiningRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroToggleDiningRoom.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroToggleDiningRoom.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.metroToggleDiningRoom.Location = new System.Drawing.Point(66, 3);
            this.metroToggleDiningRoom.Name = "metroToggleDiningRoom";
            this.metroToggleDiningRoom.Size = new System.Drawing.Size(88, 25);
            this.metroToggleDiningRoom.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroToggleDiningRoom.TabIndex = 14;
            this.metroToggleDiningRoom.Text = "On";
            this.metroToggleDiningRoom.UseSelectable = true;
            this.metroToggleDiningRoom.CheckStateChanged += new System.EventHandler(this.metroToggleDiningRoom_CheckStateChanged);
            this.metroToggleDiningRoom.Click += new System.EventHandler(this.metroToggleBathroom_Click);
            // 
            // metroScrollDiningRoom
            // 
            this.metroScrollDiningRoom.AccessibleDescription = "";
            this.metroScrollDiningRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroScrollDiningRoom.LargeChange = 10;
            this.metroScrollDiningRoom.Location = new System.Drawing.Point(3, 140);
            this.metroScrollDiningRoom.Maximum = 35;
            this.metroScrollDiningRoom.Minimum = 10;
            this.metroScrollDiningRoom.MouseWheelBarPartitions = 2;
            this.metroScrollDiningRoom.Name = "metroScrollDiningRoom";
            this.metroScrollDiningRoom.Orientation = MetroFramework.Controls.MetroScrollOrientation.Horizontal;
            this.metroScrollDiningRoom.ScrollbarSize = 15;
            this.metroScrollDiningRoom.Size = new System.Drawing.Size(200, 15);
            this.metroScrollDiningRoom.SmallChange = 2;
            this.metroScrollDiningRoom.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroScrollDiningRoom.TabIndex = 11;
            this.metroScrollDiningRoom.Tag = "";
            this.metroScrollDiningRoom.UseCustomBackColor = true;
            this.metroScrollDiningRoom.UseSelectable = true;
            this.metroScrollDiningRoom.Value = 10;
            this.metroScrollDiningRoom.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroScrollDiningRoom_Scroll);
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::SmartHome.Properties.Resources.Bathroom;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.bathRoomValue);
            this.panel6.Controls.Add(this.metroScrollBathroom);
            this.panel6.Controls.Add(this.metroToggleBathroom);
            this.panel6.Location = new System.Drawing.Point(177, 252);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(210, 160);
            this.panel6.TabIndex = 3;
            // 
            // bathRoomValue
            // 
            this.bathRoomValue.AutoSize = true;
            this.bathRoomValue.BackColor = System.Drawing.Color.Transparent;
            this.bathRoomValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bathRoomValue.ForeColor = System.Drawing.Color.White;
            this.bathRoomValue.Location = new System.Drawing.Point(68, 66);
            this.bathRoomValue.Name = "bathRoomValue";
            this.bathRoomValue.Size = new System.Drawing.Size(87, 31);
            this.bathRoomValue.TabIndex = 16;
            this.bathRoomValue.Text = "12 °C";
            this.bathRoomValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroScrollBathroom
            // 
            this.metroScrollBathroom.AccessibleDescription = "";
            this.metroScrollBathroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroScrollBathroom.LargeChange = 10;
            this.metroScrollBathroom.Location = new System.Drawing.Point(5, 140);
            this.metroScrollBathroom.Maximum = 35;
            this.metroScrollBathroom.Minimum = 10;
            this.metroScrollBathroom.MouseWheelBarPartitions = 2;
            this.metroScrollBathroom.Name = "metroScrollBathroom";
            this.metroScrollBathroom.Orientation = MetroFramework.Controls.MetroScrollOrientation.Horizontal;
            this.metroScrollBathroom.ScrollbarSize = 15;
            this.metroScrollBathroom.Size = new System.Drawing.Size(200, 15);
            this.metroScrollBathroom.SmallChange = 2;
            this.metroScrollBathroom.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroScrollBathroom.TabIndex = 11;
            this.metroScrollBathroom.Tag = "";
            this.metroScrollBathroom.UseCustomBackColor = true;
            this.metroScrollBathroom.UseSelectable = true;
            this.metroScrollBathroom.Value = 10;
            this.metroScrollBathroom.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroScrollBathroom_Scroll);
            // 
            // metroToggleBathroom
            // 
            this.metroToggleBathroom.Checked = true;
            this.metroToggleBathroom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroToggleBathroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroToggleBathroom.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroToggleBathroom.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.metroToggleBathroom.Location = new System.Drawing.Point(74, 3);
            this.metroToggleBathroom.Name = "metroToggleBathroom";
            this.metroToggleBathroom.Size = new System.Drawing.Size(88, 25);
            this.metroToggleBathroom.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroToggleBathroom.TabIndex = 13;
            this.metroToggleBathroom.Text = "On";
            this.metroToggleBathroom.UseSelectable = true;
            this.metroToggleBathroom.CheckStateChanged += new System.EventHandler(this.metroToggleBathroom_CheckStateChanged);
            this.metroToggleBathroom.Click += new System.EventHandler(this.metroToggleBathroom_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::SmartHome.Properties.Resources.bedroom1;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.bedRoomValue);
            this.panel4.Controls.Add(this.metroToggleBedRoom);
            this.panel4.Controls.Add(this.metroScrollBedRoom);
            this.panel4.Location = new System.Drawing.Point(630, 71);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(210, 160);
            this.panel4.TabIndex = 2;
            // 
            // bedRoomValue
            // 
            this.bedRoomValue.AutoSize = true;
            this.bedRoomValue.BackColor = System.Drawing.Color.Transparent;
            this.bedRoomValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bedRoomValue.ForeColor = System.Drawing.Color.White;
            this.bedRoomValue.Location = new System.Drawing.Point(68, 68);
            this.bedRoomValue.Name = "bedRoomValue";
            this.bedRoomValue.Size = new System.Drawing.Size(87, 31);
            this.bedRoomValue.TabIndex = 13;
            this.bedRoomValue.Text = "12 °C";
            this.bedRoomValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroToggleBedRoom
            // 
            this.metroToggleBedRoom.Checked = true;
            this.metroToggleBedRoom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroToggleBedRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroToggleBedRoom.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroToggleBedRoom.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.metroToggleBedRoom.Location = new System.Drawing.Point(67, 3);
            this.metroToggleBedRoom.Name = "metroToggleBedRoom";
            this.metroToggleBedRoom.Size = new System.Drawing.Size(88, 25);
            this.metroToggleBedRoom.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroToggleBedRoom.TabIndex = 12;
            this.metroToggleBedRoom.Text = "On";
            this.metroToggleBedRoom.UseSelectable = true;
            this.metroToggleBedRoom.CheckStateChanged += new System.EventHandler(this.metroToggleBedRoom_CheckStateChanged_1);
            this.metroToggleBedRoom.Click += new System.EventHandler(this.metroToggleBathroom_Click);
            // 
            // metroScrollBedRoom
            // 
            this.metroScrollBedRoom.AccessibleDescription = "";
            this.metroScrollBedRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroScrollBedRoom.LargeChange = 10;
            this.metroScrollBedRoom.Location = new System.Drawing.Point(5, 140);
            this.metroScrollBedRoom.Maximum = 35;
            this.metroScrollBedRoom.Minimum = 10;
            this.metroScrollBedRoom.MouseWheelBarPartitions = 2;
            this.metroScrollBedRoom.Name = "metroScrollBedRoom";
            this.metroScrollBedRoom.Orientation = MetroFramework.Controls.MetroScrollOrientation.Horizontal;
            this.metroScrollBedRoom.ScrollbarSize = 15;
            this.metroScrollBedRoom.Size = new System.Drawing.Size(200, 15);
            this.metroScrollBedRoom.SmallChange = 2;
            this.metroScrollBedRoom.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroScrollBedRoom.TabIndex = 11;
            this.metroScrollBedRoom.Tag = "";
            this.metroScrollBedRoom.UseCustomBackColor = true;
            this.metroScrollBedRoom.UseSelectable = true;
            this.metroScrollBedRoom.Value = 10;
            this.metroScrollBedRoom.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroScrollBedRoom_Scroll);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.kitchenValue);
            this.panel2.Controls.Add(this.metroScrollKichen);
            this.panel2.Controls.Add(this.KichenToggle);
            this.panel2.Location = new System.Drawing.Point(403, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 160);
            this.panel2.TabIndex = 1;
            // 
            // kitchenValue
            // 
            this.kitchenValue.AutoSize = true;
            this.kitchenValue.BackColor = System.Drawing.Color.Transparent;
            this.kitchenValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kitchenValue.ForeColor = System.Drawing.Color.White;
            this.kitchenValue.Location = new System.Drawing.Point(67, 68);
            this.kitchenValue.Name = "kitchenValue";
            this.kitchenValue.Size = new System.Drawing.Size(87, 31);
            this.kitchenValue.TabIndex = 12;
            this.kitchenValue.Text = "12 °C";
            this.kitchenValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroScrollKichen
            // 
            this.metroScrollKichen.AccessibleDescription = "";
            this.metroScrollKichen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroScrollKichen.LargeChange = 10;
            this.metroScrollKichen.Location = new System.Drawing.Point(5, 140);
            this.metroScrollKichen.Maximum = 35;
            this.metroScrollKichen.Minimum = 10;
            this.metroScrollKichen.MouseWheelBarPartitions = 2;
            this.metroScrollKichen.Name = "metroScrollKichen";
            this.metroScrollKichen.Orientation = MetroFramework.Controls.MetroScrollOrientation.Horizontal;
            this.metroScrollKichen.ScrollbarSize = 15;
            this.metroScrollKichen.Size = new System.Drawing.Size(200, 15);
            this.metroScrollKichen.SmallChange = 2;
            this.metroScrollKichen.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroScrollKichen.TabIndex = 11;
            this.metroScrollKichen.Tag = "";
            this.metroScrollKichen.UseCustomBackColor = true;
            this.metroScrollKichen.UseSelectable = true;
            this.metroScrollKichen.Value = 10;
            this.metroScrollKichen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroScrollKichen_Scroll);
            // 
            // KichenToggle
            // 
            this.KichenToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KichenToggle.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.KichenToggle.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.KichenToggle.Location = new System.Drawing.Point(66, 3);
            this.KichenToggle.Name = "KichenToggle";
            this.KichenToggle.Size = new System.Drawing.Size(88, 25);
            this.KichenToggle.Style = MetroFramework.MetroColorStyle.Lime;
            this.KichenToggle.TabIndex = 7;
            this.KichenToggle.Text = "Off";
            this.KichenToggle.UseSelectable = true;
            this.KichenToggle.CheckedChanged += new System.EventHandler(this.KichenToggle_CheckStateChanged);
            this.KichenToggle.Click += new System.EventHandler(this.metroToggleBathroom_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SmartHome.Properties.Resources.living_room;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.livRoomValue);
            this.panel1.Controls.Add(this.metroScrollLiving);
            this.panel1.Controls.Add(this.LivingRoomToggle);
            this.panel1.Location = new System.Drawing.Point(177, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 160);
            this.panel1.TabIndex = 0;
            // 
            // livRoomValue
            // 
            this.livRoomValue.AutoSize = true;
            this.livRoomValue.BackColor = System.Drawing.Color.Transparent;
            this.livRoomValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.livRoomValue.ForeColor = System.Drawing.Color.White;
            this.livRoomValue.Location = new System.Drawing.Point(68, 68);
            this.livRoomValue.Name = "livRoomValue";
            this.livRoomValue.Size = new System.Drawing.Size(87, 31);
            this.livRoomValue.TabIndex = 11;
            this.livRoomValue.Text = "12 °C";
            this.livRoomValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroScrollLiving
            // 
            this.metroScrollLiving.AccessibleDescription = "";
            this.metroScrollLiving.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroScrollLiving.LargeChange = 10;
            this.metroScrollLiving.Location = new System.Drawing.Point(5, 140);
            this.metroScrollLiving.Maximum = 35;
            this.metroScrollLiving.Minimum = 10;
            this.metroScrollLiving.MouseWheelBarPartitions = 35;
            this.metroScrollLiving.Name = "metroScrollLiving";
            this.metroScrollLiving.Orientation = MetroFramework.Controls.MetroScrollOrientation.Horizontal;
            this.metroScrollLiving.ScrollbarSize = 15;
            this.metroScrollLiving.Size = new System.Drawing.Size(200, 15);
            this.metroScrollLiving.SmallChange = 2;
            this.metroScrollLiving.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroScrollLiving.TabIndex = 10;
            this.metroScrollLiving.Tag = "";
            this.metroScrollLiving.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroScrollLiving.UseCustomBackColor = true;
            this.metroScrollLiving.UseSelectable = true;
            this.metroScrollLiving.Value = 10;
            this.metroScrollLiving.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroScrollLiving_Scroll);
            // 
            // LivingRoomToggle
            // 
            this.LivingRoomToggle.Checked = true;
            this.LivingRoomToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LivingRoomToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LivingRoomToggle.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.LivingRoomToggle.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.LivingRoomToggle.Location = new System.Drawing.Point(67, 3);
            this.LivingRoomToggle.Name = "LivingRoomToggle";
            this.LivingRoomToggle.Size = new System.Drawing.Size(88, 25);
            this.LivingRoomToggle.Style = MetroFramework.MetroColorStyle.Lime;
            this.LivingRoomToggle.TabIndex = 0;
            this.LivingRoomToggle.Text = "On";
            this.LivingRoomToggle.UseSelectable = true;
            this.LivingRoomToggle.CheckStateChanged += new System.EventHandler(this.LivingRoomToggle_CheckStateChanged);
            this.LivingRoomToggle.Click += new System.EventHandler(this.metroToggleBathroom_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmHeating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(864, 512);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonShedule);
            this.Controls.Add(this.btnColingOff);
            this.Controls.Add(this.btnCustom);
            this.Controls.Add(this.btnEconomy);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmHeating";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Heating";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Hladjenje_FormClosed);
            this.Load += new System.EventHandler(this.Hladjenje_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private MetroFramework.Controls.MetroToggle LivingRoomToggle;
        private Kesoft.Windows.Forms.Panels.Splitter splitter1;
        private MetroFramework.Controls.MetroToggle KichenToggle;
        private MetroFramework.Controls.MetroScrollBar metroScrollLiving;
        private MetroFramework.Controls.MetroScrollBar metroScrollKidsBedRoom;
        private MetroFramework.Controls.MetroScrollBar metroScrollDiningRoom;
        private MetroFramework.Controls.MetroScrollBar metroScrollBathroom;
        private MetroFramework.Controls.MetroScrollBar metroScrollBedRoom;
        private MetroFramework.Controls.MetroScrollBar metroScrollKichen;
        private MetroFramework.Controls.MetroToggle metroToggleBedRoom;
        private MetroFramework.Controls.MetroToggle metroToggleKidsBedRoom;
        private MetroFramework.Controls.MetroToggle metroToggleBathroom;
        private MetroFramework.Controls.MetroToggle metroToggleDiningRoom;
        private MetroFramework.Controls.MetroButton btnEconomy;
        private MetroFramework.Controls.MetroButton btnCustom;
        private MetroFramework.Controls.MetroButton btnColingOff;
        private MetroFramework.Controls.MetroButton ButtonShedule;
        private MetroFramework.Controls.MetroButton ButtonBack;
        private System.Windows.Forms.Label livRoomValue;
        private System.Windows.Forms.Label kitchenValue;
        private System.Windows.Forms.Label bedRoomValue;
        private System.Windows.Forms.Label kidsRoomValue;
        private System.Windows.Forms.Label bathRoomValue;
        private System.Windows.Forms.Label diningRoomValue;
        private MetroFramework.Controls.MetroButton btnAuto;
        private System.Windows.Forms.Timer timer1;
        
    }
}