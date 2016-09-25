using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartHome
{
    public partial class LowMediumHard : UserControl
    {
        public event EventHandler OnChangeValue;
        public LMH Value { get; set; }
        public LowMediumHard()
        {
            InitializeComponent();
        }

        private void btnLow_Click(object sender, EventArgs e)
        {
            if (this.OnChangeValue != null)
                this.OnChangeValue(this, e); 
            SetValue(LMH.Low);
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            if (this.OnChangeValue != null)
                this.OnChangeValue(this, e); 
            SetValue(LMH.Medium);
        }

        private void btnHigh_Click(object sender, EventArgs e)
        {
            if (this.OnChangeValue != null)
                this.OnChangeValue(this, e); 
            SetValue(LMH.High);
        }

        public void SetValue(LMH value)
        {
            this.Value = value;
            switch (value)
            {
                case LMH.Low:
                    {
                        btnLow.BackColor = Color.DimGray;
                        btnMedium.BackColor = Color.Gainsboro;
                        btnHigh.BackColor = Color.Gainsboro;
                        break;
                    }
                case LMH.Medium:
                    {
                        btnMedium.BackColor = Color.DimGray;
                        btnLow.BackColor = Color.Gainsboro;
                        btnHigh.BackColor = Color.Gainsboro;
                        break;
                    }
                case LMH.High:
                    {
                        btnHigh.BackColor = Color.DimGray;
                        btnMedium.BackColor = Color.Gainsboro;
                        btnLow.BackColor = Color.Gainsboro;
                        break;
                    }
            }
        }
        

    }
}
