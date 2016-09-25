namespace SmartHome
{
    partial class frmSchaduleCooling
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ButtonBack = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemove = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnSunday = new MetroFramework.Controls.MetroButton();
            this.btnSaturday = new MetroFramework.Controls.MetroButton();
            this.btnFriday = new MetroFramework.Controls.MetroButton();
            this.btnThursday = new MetroFramework.Controls.MetroButton();
            this.btnWednesday = new MetroFramework.Controls.MetroButton();
            this.btnTuesday = new MetroFramework.Controls.MetroButton();
            this.btnMonday = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonBack
            // 
            this.ButtonBack.BackColor = System.Drawing.Color.Gainsboro;
            this.ButtonBack.Location = new System.Drawing.Point(765, 461);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(83, 29);
            this.ButtonBack.TabIndex = 4;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseCustomBackColor = true;
            this.ButtonBack.UseSelectable = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEdit.Location = new System.Drawing.Point(666, 213);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(108, 42);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseCustomBackColor = true;
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.metroGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Time,
            this.Value,
            this.Active,
            this.Room});
            this.metroGrid1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle16;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(32, 67);
            this.metroGrid1.MultiSelect = false;
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.metroGrid1.RowHeadersVisible = false;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            this.metroGrid1.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.metroGrid1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.metroGrid1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.ShowCellErrors = false;
            this.metroGrid1.ShowCellToolTips = false;
            this.metroGrid1.Size = new System.Drawing.Size(564, 423);
            this.metroGrid1.TabIndex = 30;
            this.metroGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            this.metroGrid1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellValueChanged);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Time.Width = 200;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Active
            // 
            this.Active.HeaderText = "Active";
            this.Active.Name = "Active";
            // 
            // Room
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Room.DefaultCellStyle = dataGridViewCellStyle15;
            this.Room.HeaderText = "Room";
            this.Room.Name = "Room";
            this.Room.ReadOnly = true;
            this.Room.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Room.Width = 164;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRemove.Location = new System.Drawing.Point(666, 305);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(108, 42);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseCustomBackColor = true;
            this.btnRemove.UseSelectable = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.Location = new System.Drawing.Point(666, 127);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 42);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseCustomBackColor = true;
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSunday
            // 
            this.btnSunday.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSunday.Location = new System.Drawing.Point(716, 19);
            this.btnSunday.Name = "btnSunday";
            this.btnSunday.Size = new System.Drawing.Size(108, 42);
            this.btnSunday.TabIndex = 16;
            this.btnSunday.Text = "Sunday";
            this.btnSunday.UseCustomBackColor = true;
            this.btnSunday.UseSelectable = true;
            this.btnSunday.Click += new System.EventHandler(this.btnSunday_Click);
            // 
            // btnSaturday
            // 
            this.btnSaturday.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSaturday.Location = new System.Drawing.Point(602, 19);
            this.btnSaturday.Name = "btnSaturday";
            this.btnSaturday.Size = new System.Drawing.Size(108, 42);
            this.btnSaturday.TabIndex = 15;
            this.btnSaturday.Text = "Saturday";
            this.btnSaturday.UseCustomBackColor = true;
            this.btnSaturday.UseSelectable = true;
            this.btnSaturday.Click += new System.EventHandler(this.btnSaturday_Click);
            // 
            // btnFriday
            // 
            this.btnFriday.BackColor = System.Drawing.Color.Gainsboro;
            this.btnFriday.Location = new System.Drawing.Point(488, 19);
            this.btnFriday.Name = "btnFriday";
            this.btnFriday.Size = new System.Drawing.Size(108, 42);
            this.btnFriday.TabIndex = 14;
            this.btnFriday.Text = "Friday";
            this.btnFriday.UseCustomBackColor = true;
            this.btnFriday.UseSelectable = true;
            this.btnFriday.Click += new System.EventHandler(this.btnFriday_Click);
            // 
            // btnThursday
            // 
            this.btnThursday.BackColor = System.Drawing.Color.Gainsboro;
            this.btnThursday.Location = new System.Drawing.Point(146, 19);
            this.btnThursday.Name = "btnThursday";
            this.btnThursday.Size = new System.Drawing.Size(108, 42);
            this.btnThursday.TabIndex = 11;
            this.btnThursday.Text = "Thursday";
            this.btnThursday.UseCustomBackColor = true;
            this.btnThursday.UseSelectable = true;
            this.btnThursday.Click += new System.EventHandler(this.btnThursday_Click);
            // 
            // btnWednesday
            // 
            this.btnWednesday.BackColor = System.Drawing.Color.Gainsboro;
            this.btnWednesday.Location = new System.Drawing.Point(260, 19);
            this.btnWednesday.Name = "btnWednesday";
            this.btnWednesday.Size = new System.Drawing.Size(108, 42);
            this.btnWednesday.TabIndex = 12;
            this.btnWednesday.Text = "Wednesday";
            this.btnWednesday.UseCustomBackColor = true;
            this.btnWednesday.UseSelectable = true;
            this.btnWednesday.Click += new System.EventHandler(this.btnWednesday_Click);
            // 
            // btnTuesday
            // 
            this.btnTuesday.BackColor = System.Drawing.Color.Gainsboro;
            this.btnTuesday.Location = new System.Drawing.Point(374, 19);
            this.btnTuesday.Name = "btnTuesday";
            this.btnTuesday.Size = new System.Drawing.Size(108, 42);
            this.btnTuesday.TabIndex = 13;
            this.btnTuesday.Text = "Tuesday";
            this.btnTuesday.UseCustomBackColor = true;
            this.btnTuesday.UseSelectable = true;
            this.btnTuesday.Click += new System.EventHandler(this.btnThuesday_Click);
            // 
            // btnMonday
            // 
            this.btnMonday.BackColor = System.Drawing.Color.Gainsboro;
            this.btnMonday.Location = new System.Drawing.Point(32, 19);
            this.btnMonday.Name = "btnMonday";
            this.btnMonday.Size = new System.Drawing.Size(108, 42);
            this.btnMonday.TabIndex = 10;
            this.btnMonday.Text = "Monday";
            this.btnMonday.UseCustomBackColor = true;
            this.btnMonday.UseSelectable = true;
            this.btnMonday.Click += new System.EventHandler(this.btnMonday_Click);
            // 
            // frmSchaduleCooling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(864, 512);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSunday);
            this.Controls.Add(this.btnSaturday);
            this.Controls.Add(this.btnFriday);
            this.Controls.Add(this.btnThursday);
            this.Controls.Add(this.btnWednesday);
            this.Controls.Add(this.btnTuesday);
            this.Controls.Add(this.btnMonday);
            this.Name = "frmSchaduleCooling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schadule Cooling";
            this.Load += new System.EventHandler(this.frmSchaduleCooling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton ButtonBack;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroButton btnRemove;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnSunday;
        private MetroFramework.Controls.MetroButton btnSaturday;
        private MetroFramework.Controls.MetroButton btnFriday;
        private MetroFramework.Controls.MetroButton btnThursday;
        private MetroFramework.Controls.MetroButton btnWednesday;
        private MetroFramework.Controls.MetroButton btnTuesday;
        private MetroFramework.Controls.MetroButton btnMonday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Active;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room;
    }
}