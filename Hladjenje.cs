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
        private void SetActivity(string name) 
        {
            switch (name) 
            {
                case "Leaving":
                    {
                        if (!LivingRoomToggle.Checked)
                        {
                            metroScrollLiving.Enabled = false;
                            metroScrollLiving.BackColor = Color.Silver;
                            livRoomValue.Text = "";
                        }
                        else
                        {
                            metroScrollLiving.BackColor = Color.White;
                            metroScrollLiving.Enabled = true;
                            livRoomValue.Text = metroScrollLiving.Value.ToString() + " °C";
                        }
                        break;
                    }
                case "Kitchen":
                    {
                        if (!KichenToggle.Checked)
                        {
                            metroScrollKichen.Enabled = false;
                            metroScrollKichen.BackColor = Color.Silver;
                            kitchenValue.Text = "";
                        }
                        else
                        {
                            metroScrollKichen.Enabled = true;
                            metroScrollKichen.BackColor = Color.White;
                            kitchenValue.Text = metroScrollKichen.Value.ToString() + " °C";
                        }
                        break;
                    }
                case "Bed":
                    {
                        if (!metroToggleBedRoom.Checked)
                        {
                            bedRoomValue.Text = "";
                            metroScrollBedRoom.Enabled = false;
                            metroScrollBedRoom.BackColor = Color.Silver;
                        }
                        else
                        {
                            metroScrollBedRoom.Enabled = true;
                            metroScrollBedRoom.BackColor = Color.White;
                            bedRoomValue.Text = metroScrollBedRoom.Value.ToString() + " °C";
                        }
                        break;
                    }
                case "Kids":
                    {
                        if (!metroToggleKidsBedRoom.Checked)
                        {

                            metroScrollKidsBedRoom.Enabled = false;
                            metroScrollKidsBedRoom.BackColor = Color.Silver;
                            kidsRoomValue.Text = "";
                        }
                        else
                        {
                            metroScrollKidsBedRoom.Enabled = true;
                            metroScrollKidsBedRoom.BackColor = Color.White;
                            kidsRoomValue.Text = metroScrollKidsBedRoom.Value.ToString() + " °C";
                        }
                        break;
                    }
                case "Bath":
                    {
                        if (!metroToggleBathroom.Checked)
                        {
                            bathRoomValue.Text = "";
                            metroScrollBathroom.Enabled = false;
                            metroScrollBathroom.BackColor = Color.Silver;
                        }
                        else
                        {
                            metroScrollBathroom.Enabled = true;
                            metroScrollBathroom.BackColor = Color.White;
                            bathRoomValue.Text = metroScrollBathroom.Value.ToString() + " °C";
                        }
                        break;
                    }
                case "Dining":
                    {
                        if (!metroToggleDiningRoom.Checked)
                        {
                            diningRoomValue.Text = "";
                            metroScrollDiningRoom.Enabled = false;
                            metroScrollDiningRoom.BackColor = Color.Silver;
                        }
                        else
                        {
                            metroScrollDiningRoom.Enabled = true;
                            metroScrollDiningRoom.BackColor = Color.White;
                            diningRoomValue.Text = metroScrollDiningRoom.Value.ToString() + " °C";
                        }
                        break;
                    }
                case "Off":
                    {
                        metroScrollLiving.Enabled = false;
                        metroScrollLiving.BackColor = Color.Silver;
                        livRoomValue.Text = "";
                        LivingRoomToggle.Checked = false;

                        metroScrollKichen.Enabled = false;
                        metroScrollKichen.BackColor = Color.Silver;
                        kitchenValue.Text = "";
                        KichenToggle.Checked = false;

                        metroScrollKidsBedRoom.Enabled = false;
                        metroScrollKidsBedRoom.BackColor = Color.Silver;
                        kidsRoomValue.Text = "";
                        metroToggleKidsBedRoom.Checked = false;

                        diningRoomValue.Text = "";
                        metroScrollDiningRoom.Enabled = false;
                        metroScrollDiningRoom.BackColor = Color.Silver;
                        metroToggleDiningRoom.Checked = false;

                        bathRoomValue.Text = "";
                        metroScrollBathroom.Enabled = false;
                        metroScrollBathroom.BackColor = Color.Silver;
                        metroToggleBathroom.Checked = false;

                        bedRoomValue.Text = "";
                        metroScrollBedRoom.Enabled = false;
                        metroScrollBedRoom.BackColor = Color.Silver;
                        metroToggleBedRoom.Checked = false;
                        break;
                    }
            }
        }
        private void LivingRoomToggle_CheckStateChanged(object sender, EventArgs e)
        {
            SetActivity("Leaving");
        }

        private void KichenToggle_CheckStateChanged(object sender, EventArgs e)
        {
            SetActivity("Kitchen");
        }

        private void metroToggleBedRoom_CheckStateChanged_1(object sender, EventArgs e)
        {
            SetActivity("Bed");
        }

        private void metroToggleKidsBedRoom_CheckStateChanged(object sender, EventArgs e)
        {
            SetActivity("Kids");
        }

        private void metroToggleBathroom_CheckStateChanged(object sender, EventArgs e)
        {
            SetActivity("Bath");
        }

        private void metroToggleDiningRoom_CheckStateChanged(object sender, EventArgs e)
        {
            SetActivity("Dining");
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
            metroScrollBathroom.Value = 10;
            metroScrollBedRoom.Value = 8;
        }

        private void ButtonAuto_Click(object sender, EventArgs e)
        {

        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void metroScrollLiving_Scroll(object sender, ScrollEventArgs e)
        {
            if (LivingRoomToggle.Checked)
            {
                livRoomValue.Text = metroScrollLiving.Value.ToString() + " °C";
            }
        }


        private void metroScrollKichen_Scroll(object sender, ScrollEventArgs e)
        {
            if (KichenToggle.Checked)
            {
                kitchenValue.Text = metroScrollKichen.Value.ToString() + " °C";
            }
        }

        private void metroScrollBedRoom_Scroll(object sender, ScrollEventArgs e)
        {
            if (metroToggleBedRoom.Checked)
            {
                bedRoomValue.Text = metroScrollBedRoom.Value.ToString() + " °C";
            }
        }

        private void metroScrollBathroom_Scroll(object sender, ScrollEventArgs e)
        {
            bathRoomValue.Text = metroScrollBathroom.Value.ToString() + " °C";
        }

        private void metroScrollDiningRoom_Scroll(object sender, ScrollEventArgs e)
        {
            diningRoomValue.Text = metroScrollDiningRoom.Value.ToString() + " °C";
        }

        private void metroScrollKidsBedRoom_Scroll(object sender, ScrollEventArgs e)
        {
            kidsRoomValue.Text = metroScrollKidsBedRoom.Value.ToString() + " °C";
        }

        private void ButtonColingOff_Click(object sender, EventArgs e)
        {
            SetActivity("Off");
        }


        

       

      

        
        

       


       
    }
}
