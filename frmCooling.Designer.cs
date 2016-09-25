namespace SmartHome
{
    partial class frmCooling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCooling));
            this.ButtonBack = new MetroFramework.Controls.MetroButton();
            this.btnColingOff = new MetroFramework.Controls.MetroButton();
            this.btnCustom = new MetroFramework.Controls.MetroButton();
            this.btnAuto = new MetroFramework.Controls.MetroButton();
            this.btnEconomy = new MetroFramework.Controls.MetroButton();
            this.ButtonShedule = new MetroFramework.Controls.MetroButton();
            this.splitter1 = new Kesoft.Windows.Forms.Panels.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOnOffLiving = new MetroFramework.Controls.MetroToggle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOnOffKichen = new MetroFramework.Controls.MetroToggle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnOnOffBed = new MetroFramework.Controls.MetroToggle();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnOnOffBath = new MetroFramework.Controls.MetroToggle();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnOnOffDinning = new MetroFramework.Controls.MetroToggle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnOnOffKids = new MetroFramework.Controls.MetroToggle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lmhLivingRoom = new SmartHome.LowMediumHard();
            this.lmhKichen = new SmartHome.LowMediumHard();
            this.lmhBed = new SmartHome.LowMediumHard();
            this.lmhBath = new SmartHome.LowMediumHard();
            this.lmhDining = new SmartHome.LowMediumHard();
            this.lmhKids = new SmartHome.LowMediumHard();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonBack
            // 
            this.ButtonBack.BackColor = System.Drawing.Color.Gainsboro;
            this.ButtonBack.Location = new System.Drawing.Point(24, 12);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(83, 29);
            this.ButtonBack.TabIndex = 25;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseCustomBackColor = true;
            this.ButtonBack.UseSelectable = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // btnColingOff
            // 
            this.btnColingOff.BackColor = System.Drawing.Color.Gainsboro;
            this.btnColingOff.Location = new System.Drawing.Point(49, 332);
            this.btnColingOff.Name = "btnColingOff";
            this.btnColingOff.Size = new System.Drawing.Size(99, 42);
            this.btnColingOff.TabIndex = 5;
            this.btnColingOff.Text = "Cooling off";
            this.btnColingOff.UseCustomBackColor = true;
            this.btnColingOff.UseSelectable = true;
            this.btnColingOff.Click += new System.EventHandler(this.btnColingOff_Click);
            // 
            // btnCustom
            // 
            this.btnCustom.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCustom.Location = new System.Drawing.Point(49, 252);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(99, 42);
            this.btnCustom.TabIndex = 4;
            this.btnCustom.Text = "Custom";
            this.btnCustom.UseCustomBackColor = true;
            this.btnCustom.UseSelectable = true;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAuto.Location = new System.Drawing.Point(49, 174);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(99, 42);
            this.btnAuto.TabIndex = 3;
            this.btnAuto.Text = "Auto";
            this.btnAuto.UseCustomBackColor = true;
            this.btnAuto.UseSelectable = true;
            this.btnAuto.Click += new System.EventHandler(this.ButtonAuto_Click);
            // 
            // btnEconomy
            // 
            this.btnEconomy.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEconomy.Location = new System.Drawing.Point(49, 100);
            this.btnEconomy.Name = "btnEconomy";
            this.btnEconomy.Size = new System.Drawing.Size(99, 42);
            this.btnEconomy.TabIndex = 2;
            this.btnEconomy.Text = "Economy";
            this.btnEconomy.UseCustomBackColor = true;
            this.btnEconomy.UseSelectable = true;
            this.btnEconomy.Click += new System.EventHandler(this.ButtonEconomy_Click);
            // 
            // ButtonShedule
            // 
            this.ButtonShedule.BackColor = System.Drawing.Color.Gainsboro;
            this.ButtonShedule.Location = new System.Drawing.Point(414, 445);
            this.ButtonShedule.Name = "ButtonShedule";
            this.ButtonShedule.Size = new System.Drawing.Size(206, 42);
            this.ButtonShedule.TabIndex = 1;
            this.ButtonShedule.Text = "Shedule";
            this.ButtonShedule.UseCustomBackColor = true;
            this.ButtonShedule.UseSelectable = true;
            this.ButtonShedule.Click += new System.EventHandler(this.ButtonShedule_Click);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Transparent;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 512);
            this.splitter1.TabIndex = 19;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SmartHome.Properties.Resources.living_room;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnOnOffLiving);
            this.panel1.Controls.Add(this.lmhLivingRoom);
            this.panel1.Location = new System.Drawing.Point(189, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 160);
            this.panel1.TabIndex = 0;
            // 
            // btnOnOffLiving
            // 
            this.btnOnOffLiving.Checked = true;
            this.btnOnOffLiving.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnOnOffLiving.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOnOffLiving.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.btnOnOffLiving.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.btnOnOffLiving.Location = new System.Drawing.Point(61, 15);
            this.btnOnOffLiving.Name = "btnOnOffLiving";
            this.btnOnOffLiving.Size = new System.Drawing.Size(88, 25);
            this.btnOnOffLiving.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnOnOffLiving.TabIndex = 6;
            this.btnOnOffLiving.Text = "On";
            this.btnOnOffLiving.UseSelectable = true;
            this.btnOnOffLiving.CheckedChanged += new System.EventHandler(this.btnOnOffLiving_CheckedChanged);
            this.btnOnOffLiving.Click += new System.EventHandler(this.btnOnOffLiving_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnOnOffKichen);
            this.panel2.Controls.Add(this.lmhKichen);
            this.panel2.Location = new System.Drawing.Point(415, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 160);
            this.panel2.TabIndex = 14;
            // 
            // btnOnOffKichen
            // 
            this.btnOnOffKichen.Checked = true;
            this.btnOnOffKichen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnOnOffKichen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOnOffKichen.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.btnOnOffKichen.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.btnOnOffKichen.Location = new System.Drawing.Point(64, 15);
            this.btnOnOffKichen.Name = "btnOnOffKichen";
            this.btnOnOffKichen.Size = new System.Drawing.Size(88, 25);
            this.btnOnOffKichen.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnOnOffKichen.TabIndex = 7;
            this.btnOnOffKichen.Text = "On";
            this.btnOnOffKichen.UseSelectable = true;
            this.btnOnOffKichen.CheckedChanged += new System.EventHandler(this.btnOnOffKichen_CheckedChanged);
            this.btnOnOffKichen.Click += new System.EventHandler(this.btnOnOffLiving_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::SmartHome.Properties.Resources.bedroom1;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnOnOffBed);
            this.panel4.Controls.Add(this.lmhBed);
            this.panel4.Location = new System.Drawing.Point(642, 71);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(210, 160);
            this.panel4.TabIndex = 15;
            // 
            // btnOnOffBed
            // 
            this.btnOnOffBed.Checked = true;
            this.btnOnOffBed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnOnOffBed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOnOffBed.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.btnOnOffBed.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.btnOnOffBed.Location = new System.Drawing.Point(65, 15);
            this.btnOnOffBed.Name = "btnOnOffBed";
            this.btnOnOffBed.Size = new System.Drawing.Size(88, 25);
            this.btnOnOffBed.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnOnOffBed.TabIndex = 8;
            this.btnOnOffBed.Text = "On";
            this.btnOnOffBed.UseSelectable = true;
            this.btnOnOffBed.CheckedChanged += new System.EventHandler(this.btnOnOffBed_CheckedChanged);
            this.btnOnOffBed.Click += new System.EventHandler(this.btnOnOffLiving_Click);
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::SmartHome.Properties.Resources.Bathroom;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btnOnOffBath);
            this.panel6.Controls.Add(this.lmhBath);
            this.panel6.Location = new System.Drawing.Point(189, 252);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(210, 160);
            this.panel6.TabIndex = 16;
            // 
            // btnOnOffBath
            // 
            this.btnOnOffBath.Checked = true;
            this.btnOnOffBath.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnOnOffBath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOnOffBath.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.btnOnOffBath.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.btnOnOffBath.Location = new System.Drawing.Point(61, 16);
            this.btnOnOffBath.Name = "btnOnOffBath";
            this.btnOnOffBath.Size = new System.Drawing.Size(88, 25);
            this.btnOnOffBath.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnOnOffBath.TabIndex = 9;
            this.btnOnOffBath.Text = "On";
            this.btnOnOffBath.UseSelectable = true;
            this.btnOnOffBath.CheckedChanged += new System.EventHandler(this.btnOnOffBath_CheckedChanged);
            this.btnOnOffBath.Click += new System.EventHandler(this.btnOnOffLiving_Click);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::SmartHome.Properties.Resources.diningroom_main;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnOnOffDinning);
            this.panel5.Controls.Add(this.lmhDining);
            this.panel5.Location = new System.Drawing.Point(415, 252);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(210, 160);
            this.panel5.TabIndex = 17;
            // 
            // btnOnOffDinning
            // 
            this.btnOnOffDinning.Checked = true;
            this.btnOnOffDinning.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnOnOffDinning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOnOffDinning.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.btnOnOffDinning.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.btnOnOffDinning.Location = new System.Drawing.Point(64, 16);
            this.btnOnOffDinning.Name = "btnOnOffDinning";
            this.btnOnOffDinning.Size = new System.Drawing.Size(88, 25);
            this.btnOnOffDinning.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnOnOffDinning.TabIndex = 10;
            this.btnOnOffDinning.Text = "On";
            this.btnOnOffDinning.UseSelectable = true;
            this.btnOnOffDinning.CheckedChanged += new System.EventHandler(this.btnOnOffDinning_CheckedChanged);
            this.btnOnOffDinning.Click += new System.EventHandler(this.btnOnOffLiving_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::SmartHome.Properties.Resources.KidsBedRoom;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnOnOffKids);
            this.panel3.Controls.Add(this.lmhKids);
            this.panel3.Location = new System.Drawing.Point(642, 252);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 160);
            this.panel3.TabIndex = 18;
            // 
            // btnOnOffKids
            // 
            this.btnOnOffKids.Checked = true;
            this.btnOnOffKids.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnOnOffKids.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOnOffKids.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.btnOnOffKids.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.btnOnOffKids.Location = new System.Drawing.Point(65, 16);
            this.btnOnOffKids.Name = "btnOnOffKids";
            this.btnOnOffKids.Size = new System.Drawing.Size(88, 25);
            this.btnOnOffKids.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnOnOffKids.TabIndex = 11;
            this.btnOnOffKids.Text = "On";
            this.btnOnOffKids.UseSelectable = true;
            this.btnOnOffKids.CheckedChanged += new System.EventHandler(this.btnOnOffKids_CheckedChanged);
            this.btnOnOffKids.Click += new System.EventHandler(this.btnOnOffLiving_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lmhLivingRoom
            // 
            this.lmhLivingRoom.BackColor = System.Drawing.Color.Transparent;
            this.lmhLivingRoom.Location = new System.Drawing.Point(6, 125);
            this.lmhLivingRoom.Name = "lmhLivingRoom";
            this.lmhLivingRoom.Size = new System.Drawing.Size(197, 34);
            this.lmhLivingRoom.TabIndex = 0;
            this.lmhLivingRoom.Value = SmartHome.LMH.Low;
            this.lmhLivingRoom.OnChangeValue += new System.EventHandler(this.btnCustom_Click);
            // 
            // lmhKichen
            // 
            this.lmhKichen.BackColor = System.Drawing.Color.Transparent;
            this.lmhKichen.Location = new System.Drawing.Point(3, 125);
            this.lmhKichen.Name = "lmhKichen";
            this.lmhKichen.Size = new System.Drawing.Size(197, 34);
            this.lmhKichen.TabIndex = 1;
            this.lmhKichen.Value = SmartHome.LMH.Low;
            this.lmhKichen.OnChangeValue += new System.EventHandler(this.btnCustom_Click);
            // 
            // lmhBed
            // 
            this.lmhBed.BackColor = System.Drawing.Color.Transparent;
            this.lmhBed.Location = new System.Drawing.Point(3, 125);
            this.lmhBed.Name = "lmhBed";
            this.lmhBed.Size = new System.Drawing.Size(197, 34);
            this.lmhBed.TabIndex = 2;
            this.lmhBed.Value = SmartHome.LMH.Low;
            this.lmhBed.OnChangeValue += new System.EventHandler(this.btnCustom_Click);
            // 
            // lmhBath
            // 
            this.lmhBath.BackColor = System.Drawing.Color.Transparent;
            this.lmhBath.Location = new System.Drawing.Point(3, 121);
            this.lmhBath.Name = "lmhBath";
            this.lmhBath.Size = new System.Drawing.Size(197, 34);
            this.lmhBath.TabIndex = 2;
            this.lmhBath.Value = SmartHome.LMH.Low;
            this.lmhBath.OnChangeValue += new System.EventHandler(this.btnCustom_Click);
            // 
            // lmhDining
            // 
            this.lmhDining.BackColor = System.Drawing.Color.Transparent;
            this.lmhDining.Location = new System.Drawing.Point(3, 121);
            this.lmhDining.Name = "lmhDining";
            this.lmhDining.Size = new System.Drawing.Size(197, 34);
            this.lmhDining.TabIndex = 2;
            this.lmhDining.Value = SmartHome.LMH.Low;
            this.lmhDining.OnChangeValue += new System.EventHandler(this.btnCustom_Click);
            // 
            // lmhKids
            // 
            this.lmhKids.BackColor = System.Drawing.Color.Transparent;
            this.lmhKids.Location = new System.Drawing.Point(3, 121);
            this.lmhKids.Name = "lmhKids";
            this.lmhKids.Size = new System.Drawing.Size(197, 34);
            this.lmhKids.TabIndex = 2;
            this.lmhKids.Value = SmartHome.LMH.Low;
            this.lmhKids.OnChangeValue += new System.EventHandler(this.btnCustom_Click);
            // 
            // frmCooling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(864, 512);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.btnColingOff);
            this.Controls.Add(this.btnCustom);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.btnEconomy);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.ButtonShedule);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel3);
            this.Name = "frmCooling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cooling";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCooling_FormClosing);
            this.Load += new System.EventHandler(this.frmCooling_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton ButtonBack;
        private MetroFramework.Controls.MetroButton btnColingOff;
        private MetroFramework.Controls.MetroButton btnCustom;
        private MetroFramework.Controls.MetroButton btnAuto;
        private MetroFramework.Controls.MetroButton btnEconomy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private MetroFramework.Controls.MetroButton ButtonShedule;
        private Kesoft.Windows.Forms.Panels.Splitter splitter1;
        private System.Windows.Forms.Panel panel3;
        private LowMediumHard lmhLivingRoom;
        private LowMediumHard lmhKids;
        private LowMediumHard lmhKichen;
        private LowMediumHard lmhBed;
        private LowMediumHard lmhBath;
        private LowMediumHard lmhDining;
        private MetroFramework.Controls.MetroToggle btnOnOffKids;
        private MetroFramework.Controls.MetroToggle btnOnOffLiving;
        private MetroFramework.Controls.MetroToggle btnOnOffKichen;
        private MetroFramework.Controls.MetroToggle btnOnOffBed;
        private MetroFramework.Controls.MetroToggle btnOnOffBath;
        private MetroFramework.Controls.MetroToggle btnOnOffDinning;
        private System.Windows.Forms.Timer timer1;
    }
}