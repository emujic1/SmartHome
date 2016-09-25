namespace SmartHome
{
    partial class LowMediumHard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLow = new MetroFramework.Controls.MetroButton();
            this.btnMedium = new MetroFramework.Controls.MetroButton();
            this.btnHigh = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnLow
            // 
            this.btnLow.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLow.Location = new System.Drawing.Point(3, 0);
            this.btnLow.Name = "btnLow";
            this.btnLow.Size = new System.Drawing.Size(60, 29);
            this.btnLow.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnLow.TabIndex = 0;
            this.btnLow.Text = "Low";
            this.btnLow.UseCustomBackColor = true;
            this.btnLow.UseSelectable = true;
            this.btnLow.Click += new System.EventHandler(this.btnLow_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.BackColor = System.Drawing.Color.Gainsboro;
            this.btnMedium.Location = new System.Drawing.Point(69, 0);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(60, 29);
            this.btnMedium.TabIndex = 1;
            this.btnMedium.Text = "Medium";
            this.btnMedium.UseCustomBackColor = true;
            this.btnMedium.UseSelectable = true;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            // 
            // btnHigh
            // 
            this.btnHigh.BackColor = System.Drawing.Color.Gainsboro;
            this.btnHigh.Location = new System.Drawing.Point(135, 0);
            this.btnHigh.Name = "btnHigh";
            this.btnHigh.Size = new System.Drawing.Size(60, 29);
            this.btnHigh.TabIndex = 2;
            this.btnHigh.Text = "High";
            this.btnHigh.UseCustomBackColor = true;
            this.btnHigh.UseSelectable = true;
            this.btnHigh.Click += new System.EventHandler(this.btnHigh_Click);
            // 
            // LowMediumHard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnHigh);
            this.Controls.Add(this.btnMedium);
            this.Controls.Add(this.btnLow);
            this.Name = "LowMediumHard";
            this.Size = new System.Drawing.Size(197, 34);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnMedium;
        private MetroFramework.Controls.MetroButton btnHigh;
        public MetroFramework.Controls.MetroButton btnLow;
    }
}
