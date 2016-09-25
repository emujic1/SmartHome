using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartHome
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            CoolingType.HeatingTypeNow = CoolingTypes.Off;
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            Scheduled.scheduledHeatingRooms = new List<ScheduledHeatingRoom>();
            Scheduled.scheduledCoolingRooms = new List<ScheduledCoolingRoom>();
            CoolingType.CoolingTypeNow = CoolingTypes.Off;
            CoolingType.HeatingTypeNow = CoolingTypes.Off;
            LabelSecurity.Text = "";
            metroLabel1.Text = "";
            metroLabel2.Text = "";
            LabelCooling.Text = "";
        }

        private void hladjenje_Click(object sender, EventArgs e)
        {
            new frmCooling().ShowDialog();
        }

        private void sigurnost_Click(object sender, EventArgs e)
        {
            Sigurnost sigurnost = new Sigurnost();
            sigurnost.ShowDialog();
        }

        private void grijanje_Click(object sender, EventArgs e)
        {
            new frmHeating().ShowDialog();
        }

        private void izvjestaj_Click(object sender, EventArgs e)
        {
            Izvjestaj izvjestaj = new Izvjestaj();
            izvjestaj.ShowDialog();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void hladjenje_MouseHover(object sender, EventArgs e)
        {
            LabelCooling.Text = "Cooling";
        }

        private void hladjenje_MouseLeave(object sender, EventArgs e)
        {
            LabelCooling.Text = "";
        }

        private void sigurnost_MouseHover(object sender, EventArgs e)
        {
            LabelSecurity.Text = "Security";
        }

        private void sigurnost_MouseLeave(object sender, EventArgs e)
        {
            LabelSecurity.Text = "";
        }

        private void grijanje_MouseHover(object sender, EventArgs e)
        {
            metroLabel1.Text = "Heating";
        }

        private void grijanje_MouseLeave(object sender, EventArgs e)
        {
            metroLabel1.Text = "";
        }

        private void izvjestaj_MouseHover(object sender, EventArgs e)
        {
            metroLabel2.Text = "Report";
        }

        private void izvjestaj_MouseLeave(object sender, EventArgs e)
        {
            metroLabel2.Text = "";
        }

        private void Web_Click(object sender, EventArgs e)
        {
            Browser b = new Browser();
            b.ShowDialog();
        }


    }
}

   
