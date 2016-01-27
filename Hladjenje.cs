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
    public partial class Hladjenje : Form
    {
        public Hladjenje()
        {
            InitializeComponent();
        }
        private void Hladjenje_Load(object sender, EventArgs e)
        {
            CheckToogles();

        }
        private void LivingRoomToggle_CheckStateChanged(object sender, EventArgs e)
        {

            if (LivingRoomToggle.Text == "Off")
            {
                metroScrollLiving.Enabled = false;
                metroScrollLiving.BackColor = Color.Silver;

            }
            else
            {
                metroScrollLiving.BackColor = Color.White;
                metroScrollLiving.Enabled = true;
                
            }

        }

        private void KichenToggle_CheckStateChanged(object sender, EventArgs e)
        {

            if (KichenToggle.Text == "Off")
            {
                metroScrollKichen.Enabled = false;
                metroScrollKichen.BackColor = Color.Silver;
            }
            else
            {
                metroScrollKichen.Enabled = true;
                metroScrollKichen.BackColor = Color.White;
            }
        }

        private void metroToggleBedRoom_CheckStateChanged_1(object sender, EventArgs e)
        {
            if (metroToggleBedRoom.Text == "Off")
            {

                metroScrollBedRoom.Enabled = false;
                metroScrollBedRoom.BackColor = Color.Silver;
            }
            else
            {
                metroScrollBedRoom.Enabled = true;
                metroScrollBedRoom.BackColor = Color.White;
            }
        }

        private void metroToggleKidsBedRoom_CheckStateChanged(object sender, EventArgs e)
        {
            if (metroToggleKidsBedRoom.Text == "Off")
            {

                metroScrollKidsBedRoom.Enabled = false;
                metroScrollKidsBedRoom.BackColor = Color.Silver;
            }
            else
            {
                metroScrollKidsBedRoom.Enabled = true;
                metroScrollKidsBedRoom.BackColor = Color.White;
            }
        }

        private void metroToggleBathroom_CheckStateChanged(object sender, EventArgs e)
        {
            if (metroToggleBathroom.Text == "Off")
            {

                metroScrollBathroom.Enabled = false;
                metroScrollBathroom.BackColor = Color.Silver;
            }
            else
            {
                metroScrollBathroom.Enabled = true;
                metroScrollBathroom.BackColor = Color.White;
            }
        }

        private void metroToggleDiningRoom_CheckStateChanged(object sender, EventArgs e)
        {
            if (metroToggleDiningRoom.Text == "Off")
            {

                metroScrollDiningRoom.Enabled = false;
                metroScrollDiningRoom.BackColor = Color.Silver;
            }
            else
            {
                metroScrollDiningRoom.Enabled = true;
                metroScrollDiningRoom.BackColor = Color.White;
            }
        }

      
        public void CheckToogles()
        {
            //check kichen toogle and color
            if (KichenToggle.Text == "Off")
            {
                metroScrollKichen.Enabled = false;
                metroScrollKichen.BackColor = Color.Silver;
            }
            else
            {
                metroScrollKichen.Enabled = true;
                metroScrollKichen.BackColor = Color.White;
            }
            //check Livingroom toogle and color
            if (LivingRoomToggle.Text == "Off")
            {
                metroScrollLiving.Enabled = false;
                metroScrollLiving.BackColor = Color.Silver;

            }
            else
            {
                metroScrollLiving.BackColor = Color.White;
                metroScrollLiving.Enabled = true;

            }
            //check Bedroom toogle and color
            if (metroToggleBedRoom.Text == "Off")
            {

                metroScrollBedRoom.Enabled = false;
                metroScrollBedRoom.BackColor = Color.Silver;
            }
            else
            {
                metroScrollBedRoom.Enabled = true;
                metroScrollBedRoom.BackColor = Color.White;
            }
            if (metroToggleDiningRoom.Text == "Off")
            {

                metroScrollDiningRoom.Enabled = false;
                metroScrollDiningRoom.BackColor = Color.Silver;
            }
            else
            {
                metroScrollDiningRoom.Enabled = true;
                metroScrollDiningRoom.BackColor = Color.White;
            }
            if (metroToggleBathroom.Text == "Off")
            {

                metroScrollBathroom.Enabled = false;
                metroScrollBathroom.BackColor = Color.Silver;
            }
            else
            {
                metroScrollBathroom.Enabled = true;
                metroScrollBathroom.BackColor = Color.White;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonAuto_Click(object sender, EventArgs e)
        {

        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        

       


       
    }
}
