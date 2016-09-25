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
    public partial class frmHeating : Form
    {
        public frmHeating()
        {
            InitializeComponent();
        }
        private void Hladjenje_Load(object sender, EventArgs e)
        {
            CheckToogles();
            checkCoolingType();
            timer1.Start();

        }
        private void checkCoolingType ()
        {
            switch(CoolingType.HeatingTypeNow)
            {
                case CoolingTypes.Off:
                    {
                        SetButtonsCoolor(CoolingTypes.Off);
                        SetActivity("Off");
                        break;
                    }
                case CoolingTypes.Economy:
                    {
                        SetButtonsCoolor(CoolingTypes.Economy);
                        metroButton1_Click(null, null);
                        break;
                    }
                case CoolingTypes.Auto:
                    {
                        SetButtonsCoolor(CoolingTypes.Auto);
                        FillValuesOnAuto();
                        break;
                    }
                case CoolingTypes.Custom:
                    {
                        SetButtonsCoolor(CoolingTypes.Custom);
                        metroToggleBathroom.Checked = CustomValuesOnHeating.BathRoom.isActive;
                        metroScrollBathroom.Value = CustomValuesOnHeating.BathRoom.Value;
                        metroToggleDiningRoom.Checked = CustomValuesOnHeating.DiningRoom.isActive;
                        metroScrollDiningRoom.Value =CustomValuesOnHeating.DiningRoom.Value;
                        metroToggleBedRoom.Checked = CustomValuesOnHeating.BedRoom.isActive;
                        metroScrollBedRoom.Value = CustomValuesOnHeating.BedRoom.Value;
                        KichenToggle.Checked = CustomValuesOnHeating.Kichen.isActive; 
                        metroScrollKichen.Value = CustomValuesOnHeating.Kichen.Value;
                        metroToggleKidsBedRoom.Checked = CustomValuesOnHeating.KidsRoom.isActive;
                        metroScrollKidsBedRoom.Value = CustomValuesOnHeating.KidsRoom.Value;
                        metroScrollLiving.Value = CustomValuesOnHeating.LivingRoom.Value;
                        LivingRoomToggle.Checked = CustomValuesOnHeating.LivingRoom.isActive;
                       
                        LivingRoomToggle_CheckStateChanged(null, null);
                        this.metroToggleBathroom_CheckStateChanged(null, null);
                        this.metroToggleDiningRoom_CheckStateChanged(null, null);
                        this.metroToggleKidsBedRoom_CheckStateChanged(null, null);
                        this.KichenToggle_CheckStateChanged(null, null);
                        this.metroToggleBedRoom_CheckStateChanged_1(null, null);
                        break;
                    }
            }

        }
        private void FillValuesOnAuto()
        {
            if(CoolingType.HeatingTypeNow == CoolingTypes.Auto)
            {
                SetActivity("Off");
                DateTime dateTimeNow = new DateTime(2010, 10, 10, DateTime.Now.Hour, DateTime.Now.Minute, 0);
                foreach(var item in Scheduled.scheduledHeatingRooms)
                {
                    if (dateTimeNow > item.From && dateTimeNow < item.To && item.IsActive && item.Day == dateTimeNow.DayOfWeek)
                    {
                        checkScheduledRoomAndSetValues(item);
                    }
                }
            }
        }

        private void checkScheduledRoomAndSetValues(ScheduledHeatingRoom room)
        {
            switch(room.Room)
            {
                case RoomType.LivingRoom:
                    {
                        metroScrollLiving.Enabled = true;
                        metroScrollLiving.Value = room.Value;
                        livRoomValue.Text = room.Value.ToString() +" °C";
                        LivingRoomToggle.Checked = true;
                        LivingRoomToggle_CheckStateChanged(null, null);
                        break;
                    }
                case RoomType.BathRoom:
                    {

                        metroScrollBathroom.Enabled = true;
                        metroScrollBathroom.Value = room.Value;
                        bathRoomValue.Text = room.Value.ToString() + " °C";
                        metroToggleBathroom.Checked = true;
                        metroToggleBathroom_CheckStateChanged(null, null);
                        break;
                    }
                case RoomType.DiningRoom:
                    {
                        metroScrollDiningRoom.Enabled = true;
                        metroScrollDiningRoom.Value = room.Value;
                        diningRoomValue.Text = room.Value.ToString() + " °C";
                        metroToggleDiningRoom.Checked = true;
                        metroToggleDiningRoom_CheckStateChanged(null, null);
                       break;
                    }
                case RoomType.KidsRoom:
                    {
                        metroScrollKidsBedRoom.Enabled = true;
                        metroScrollKidsBedRoom.Value = room.Value;
                        kidsRoomValue.Text = room.Value.ToString() + " °C";
                        metroToggleKidsBedRoom.Checked = true;
                        metroToggleKidsBedRoom_CheckStateChanged(null, null);
                         break;
                    }
                case RoomType.Kichen:
                    {
                        metroScrollKichen.Enabled = true;
                        metroScrollKichen.Value = room.Value;
                        kitchenValue.Text = room.Value.ToString() + " °C";
                        KichenToggle.Checked = true;
                        KichenToggle_CheckStateChanged(null, null);
                        break;
                    }
                case RoomType.BedRoom:
                    {
                        metroScrollBedRoom.Enabled = true;
                        metroScrollBedRoom.Value = room.Value;
                        bedRoomValue.Text = room.Value.ToString() + " °C";
                        metroToggleBedRoom.Checked = true;
                        metroToggleBedRoom_CheckStateChanged_1(null, null);
                        break;
                    }
            }

        }

        public void SetButtonsCoolor(CoolingTypes value)
        {
            CoolingType.HeatingTypeNow = value;
            switch (value)
            {
                case CoolingTypes.Auto:
                    {
                        btnAuto.BackColor = Color.DimGray;
                        btnColingOff.BackColor = Color.Gainsboro;
                        btnCustom.BackColor = Color.Gainsboro;
                        btnEconomy.BackColor = Color.Gainsboro;
                        break;
                    }
                case CoolingTypes.Custom:
                    {
                        btnAuto.BackColor = Color.Gainsboro;
                        btnColingOff.BackColor = Color.Gainsboro;
                        btnCustom.BackColor = Color.DimGray;
                        btnEconomy.BackColor = Color.Gainsboro;
                        break;
                    }
                case CoolingTypes.Economy:
                    {
                        btnAuto.BackColor = Color.Gainsboro;
                        btnColingOff.BackColor = Color.Gainsboro;
                        btnCustom.BackColor = Color.Gainsboro;
                        btnEconomy.BackColor = Color.DimGray;
                        break;
                    }
                case CoolingTypes.Off:
                    {
                        btnAuto.BackColor = Color.Gainsboro;
                        btnColingOff.BackColor = Color.DimGray;
                        btnCustom.BackColor = Color.Gainsboro;
                        btnEconomy.BackColor = Color.Gainsboro;
                        break;
                    }
            }
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
            timer1.Stop();
            CoolingType.HeatingTypeNow = CoolingTypes.Economy;
            metroScrollLiving.Enabled = true;
            metroScrollLiving.Value = 24;
            livRoomValue.Text = "24 °C";
            LivingRoomToggle.Checked = true;
            LivingRoomToggle_CheckStateChanged(sender, e);

            metroScrollBathroom.Enabled = true;
            metroScrollBathroom.Value = 20;
            bathRoomValue.Text = "20 °C";
            metroToggleBathroom.Checked = true;
            this.metroToggleBathroom_CheckStateChanged(sender, e);

            metroScrollDiningRoom.Enabled = true;
            metroScrollDiningRoom.Value = 26;
            diningRoomValue.Text = "26 °C";
            metroToggleDiningRoom.Checked = true;
            this.metroToggleDiningRoom_CheckStateChanged(sender, e);

            metroScrollKidsBedRoom.Enabled = true;
            metroScrollKidsBedRoom.Value = 25;
            kidsRoomValue.Text = "25 °C";
            metroToggleKidsBedRoom.Checked = true;
            this.metroToggleKidsBedRoom_CheckStateChanged(sender, e);

           
            metroScrollKichen.Enabled = true;
            metroScrollKichen.Value = 27;
            kitchenValue.Text = "27 °C";
            KichenToggle.Checked = true;
            this.KichenToggle_CheckStateChanged(sender, e);

            metroScrollBedRoom.Enabled = true;
            metroScrollBedRoom.Value = 26;
            bedRoomValue.Text = "26 °C";
            metroToggleBedRoom.Checked = true;
            this.metroToggleBedRoom_CheckStateChanged_1(sender, e);

            SetButtonsCoolor(CoolingTypes.Economy);

        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            checkClosingFormToFillCustomData();
            Close();
        }

        private void metroScrollLiving_Scroll(object sender, ScrollEventArgs e)
        {
            if (LivingRoomToggle.Checked)
            {
                SetButtonsCoolor(CoolingTypes.Custom);
                livRoomValue.Text = metroScrollLiving.Value.ToString() + " °C";
            }
        }


        private void metroScrollKichen_Scroll(object sender, ScrollEventArgs e)
        {
            if (KichenToggle.Checked)
            {
                SetButtonsCoolor(CoolingTypes.Custom);
                kitchenValue.Text = metroScrollKichen.Value.ToString() + " °C";
            }
        }

        private void metroScrollBedRoom_Scroll(object sender, ScrollEventArgs e)
        {
            if (metroToggleBedRoom.Checked)
            {
                SetButtonsCoolor(CoolingTypes.Custom);
                bedRoomValue.Text = metroScrollBedRoom.Value.ToString() + " °C";
            }
        }

        private void metroScrollBathroom_Scroll(object sender, ScrollEventArgs e)
        {
            SetButtonsCoolor(CoolingTypes.Custom);
            bathRoomValue.Text = metroScrollBathroom.Value.ToString() + " °C";
        }

        private void metroScrollDiningRoom_Scroll(object sender, ScrollEventArgs e)
        {
            SetButtonsCoolor(CoolingTypes.Custom);
            diningRoomValue.Text = metroScrollDiningRoom.Value.ToString() + " °C";
        }

        private void metroScrollKidsBedRoom_Scroll(object sender, ScrollEventArgs e)
        {
            SetButtonsCoolor(CoolingTypes.Custom);
            kidsRoomValue.Text = metroScrollKidsBedRoom.Value.ToString() + " °C";
        }

        private void ButtonColingOff_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            SetActivity("Off");
            CoolingType.HeatingTypeNow = CoolingTypes.Off;
            SetButtonsCoolor(CoolingTypes.Off);
        }

        private void ButtonAuto_Click(object sender, EventArgs e)
        {
            CoolingType.HeatingTypeNow = CoolingTypes.Auto;
            timer1.Start();
            FillValuesOnAuto();
            SetButtonsCoolor(CoolingTypes.Auto);
        }

        private void ButtonCustom_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            CoolingType.HeatingTypeNow = CoolingTypes.Custom;
            SetButtonsCoolor(CoolingTypes.Custom);
        }

        private void Hladjenje_FormClosed(object sender, FormClosedEventArgs e)
        {
            checkClosingFormToFillCustomData();
        }
        private void checkClosingFormToFillCustomData ()
        {
            if(CoolingType.HeatingTypeNow == CoolingTypes.Custom)
            {
                CustomValuesOnHeating.BathRoom = new HeatingRoom 
                { 
                    isActive = metroToggleBathroom.Checked,
                    Value = metroScrollBathroom.Value
                };
                CustomValuesOnHeating.DiningRoom = new HeatingRoom
                {
                    isActive = metroToggleDiningRoom.Checked,
                    Value = metroScrollDiningRoom.Value
                };
                CustomValuesOnHeating.BedRoom = new HeatingRoom 
                {
                    isActive = metroToggleBedRoom.Checked,
                    Value = metroScrollBedRoom.Value
                };
                CustomValuesOnHeating.Kichen = new HeatingRoom 
                {
                    isActive = KichenToggle.Checked,
                    Value = metroScrollKichen.Value
                };
                CustomValuesOnHeating.KidsRoom = new HeatingRoom
                {
                    isActive = metroToggleKidsBedRoom.Checked,
                    Value = metroScrollKidsBedRoom.Value
                };
                CustomValuesOnHeating.LivingRoom = new HeatingRoom
                {
                    Value = metroScrollLiving.Value,
                    isActive = LivingRoomToggle.Checked
                };
            }
        }

        private void ButtonShedule_Click(object sender, EventArgs e)
        {
            new frmScheduleHeating().ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            FillValuesOnAuto();
        }

        private void metroToggleBathroom_Click(object sender, EventArgs e)
        {
            SetButtonsCoolor(CoolingTypes.Custom);
        }

    }
}
