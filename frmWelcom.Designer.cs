namespace SmartHome
{
    partial class Welcome
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
            this.LabelCooling = new MetroFramework.Controls.MetroLabel();
            this.LabelSecurity = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.grijanje = new System.Windows.Forms.Button();
            this.sigurnost = new System.Windows.Forms.Button();
            this.izvjestaj = new System.Windows.Forms.Button();
            this.hladjenje = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Web = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // LabelCooling
            // 
            this.LabelCooling.AutoSize = true;
            this.LabelCooling.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LabelCooling.Location = new System.Drawing.Point(220, 162);
            this.LabelCooling.Name = "LabelCooling";
            this.LabelCooling.Size = new System.Drawing.Size(71, 25);
            this.LabelCooling.TabIndex = 4;
            this.LabelCooling.Text = "Cooling";
            this.LabelCooling.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // LabelSecurity
            // 
            this.LabelSecurity.AutoSize = true;
            this.LabelSecurity.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LabelSecurity.Location = new System.Drawing.Point(395, 3);
            this.LabelSecurity.Name = "LabelSecurity";
            this.LabelSecurity.Size = new System.Drawing.Size(71, 25);
            this.LabelSecurity.TabIndex = 5;
            this.LabelSecurity.Text = "Security";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(550, 162);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 25);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Heating";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(404, 345);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 25);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Report";
            // 
            // grijanje
            // 
            this.grijanje.BackgroundImage = global::SmartHome.Properties.Resources._12540116_10208519042912361_719427840_n;
            this.grijanje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grijanje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grijanje.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.grijanje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grijanje.ForeColor = System.Drawing.Color.White;
            this.grijanje.Location = new System.Drawing.Point(520, 190);
            this.grijanje.Name = "grijanje";
            this.grijanje.Size = new System.Drawing.Size(125, 125);
            this.grijanje.TabIndex = 3;
            this.grijanje.TabStop = false;
            this.grijanje.UseVisualStyleBackColor = true;
            this.grijanje.Click += new System.EventHandler(this.grijanje_Click);
            this.grijanje.MouseLeave += new System.EventHandler(this.grijanje_MouseLeave);
            this.grijanje.MouseHover += new System.EventHandler(this.grijanje_MouseHover);
            // 
            // sigurnost
            // 
            this.sigurnost.BackgroundImage = global::SmartHome.Properties.Resources._12506607_10208519042792358_1037114543_n;
            this.sigurnost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sigurnost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sigurnost.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.sigurnost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sigurnost.ForeColor = System.Drawing.Color.White;
            this.sigurnost.Location = new System.Drawing.Point(364, 31);
            this.sigurnost.Name = "sigurnost";
            this.sigurnost.Size = new System.Drawing.Size(125, 125);
            this.sigurnost.TabIndex = 2;
            this.sigurnost.TabStop = false;
            this.sigurnost.Text = "n";
            this.sigurnost.UseVisualStyleBackColor = true;
            this.sigurnost.Click += new System.EventHandler(this.sigurnost_Click);
            this.sigurnost.MouseLeave += new System.EventHandler(this.sigurnost_MouseLeave);
            this.sigurnost.MouseHover += new System.EventHandler(this.sigurnost_MouseHover);
            // 
            // izvjestaj
            // 
            this.izvjestaj.BackgroundImage = global::SmartHome.Properties.Resources._12498764_10208519041512326_900510296_n;
            this.izvjestaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.izvjestaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.izvjestaj.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.izvjestaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.izvjestaj.ForeColor = System.Drawing.Color.White;
            this.izvjestaj.Location = new System.Drawing.Point(364, 375);
            this.izvjestaj.Name = "izvjestaj";
            this.izvjestaj.Size = new System.Drawing.Size(125, 125);
            this.izvjestaj.TabIndex = 2;
            this.izvjestaj.TabStop = false;
            this.izvjestaj.UseVisualStyleBackColor = true;
            this.izvjestaj.Click += new System.EventHandler(this.izvjestaj_Click);
            this.izvjestaj.MouseLeave += new System.EventHandler(this.izvjestaj_MouseLeave);
            this.izvjestaj.MouseHover += new System.EventHandler(this.izvjestaj_MouseHover);
            // 
            // hladjenje
            // 
            this.hladjenje.BackgroundImage = global::SmartHome.Properties.Resources.hladjenje;
            this.hladjenje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hladjenje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hladjenje.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.hladjenje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hladjenje.ForeColor = System.Drawing.Color.White;
            this.hladjenje.Location = new System.Drawing.Point(192, 185);
            this.hladjenje.Name = "hladjenje";
            this.hladjenje.Size = new System.Drawing.Size(125, 125);
            this.hladjenje.TabIndex = 1;
            this.hladjenje.TabStop = false;
            this.hladjenje.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hladjenje.UseVisualStyleBackColor = true;
            this.hladjenje.Click += new System.EventHandler(this.hladjenje_Click);
            this.hladjenje.MouseLeave += new System.EventHandler(this.hladjenje_MouseLeave);
            this.hladjenje.MouseHover += new System.EventHandler(this.hladjenje_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SmartHome.Properties.Resources.pokit_3416a75f4cea9109507cacd8e2f2aefc;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(332, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 180);
            this.panel1.TabIndex = 0;
            // 
            // Web
            // 
            this.Web.Location = new System.Drawing.Point(763, 31);
            this.Web.Name = "Web";
            this.Web.Size = new System.Drawing.Size(75, 23);
            this.Web.TabIndex = 8;
            this.Web.Text = "Web";
            this.Web.UseSelectable = true;
            this.Web.Click += new System.EventHandler(this.Web_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(864, 512);
            this.Controls.Add(this.Web);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.LabelSecurity);
            this.Controls.Add(this.LabelCooling);
            this.Controls.Add(this.grijanje);
            this.Controls.Add(this.sigurnost);
            this.Controls.Add(this.izvjestaj);
            this.Controls.Add(this.hladjenje);
            this.Controls.Add(this.panel1);
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Home";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button hladjenje;
        private System.Windows.Forms.Button izvjestaj;
        private System.Windows.Forms.Button sigurnost;
        private System.Windows.Forms.Button grijanje;
        private MetroFramework.Controls.MetroLabel LabelCooling;
        private MetroFramework.Controls.MetroLabel LabelSecurity;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton Web;

    }
}

