using SmartHome.Models;
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
    public partial class frmCooling : Form
    {

        public frmCooling()
        {
            InitializeComponent();
        }

        private void frmCooling_Load(object sender, EventArgs e)
        {
            CheckCoolingTypeNow();
        }

        private void CheckCoolingTypeNow()
        {
            SetButtonsCoolor(CoolingType.CoolingTypeNow);
            switch(CoolingType.CoolingTypeNow)
            {
                case CoolingTypes.Auto:
                    {
                        ButtonAuto_Click(null, null);
                        break;
                    }
                case CoolingTypes.Custom:
                    {
                        lmhBath.SetValue(CustomValuesOnCooling.BathRoom.Value);
                        btnOnOffBath.Checked = CustomValuesOnCooling.BathRoom.IsActive;
                        lmhBed.SetValue(CustomValuesOnCooling.BedRoom.Value);
                        btnOnOffBed.Checked = CustomValuesOnCooling.BedRoom.IsActive;
                        lmhKichen.SetValue(CustomValuesOnCooling.Kichen.Value);
                        btnOnOffKichen.Checked = CustomValuesOnCooling.Kichen.IsActive;
                        lmhDining.SetValue(CustomValuesOnCooling.DiningRoom.Value);
                        btnOnOffDinning.Checked = CustomValuesOnCooling.DiningRoom.IsActive;
                        lmhKids.SetValue(CustomValuesOnCooling.KidsRoom.Value);
                        btnOnOffKids.Checked = CustomValuesOnCooling.KidsRoom.IsActive;
                        lmhLivingRoom.SetValue(CustomValuesOnCooling.LivingRoom.Value);
                        btnOnOffLiving.Checked = CustomValuesOnCooling.LivingRoom.IsActive;
                        break;
                    }
                case CoolingTypes.Economy:
                    {
                        ButtonEconomy_Click(null, null);
                        break;
                    }
                case CoolingTypes.Off:
                    {
                        this.btnColingOff_Click(null, null);
                        break;
                    }
            }
        }
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonShedule_Click(object sender, EventArgs e)
        {
            new frmSchaduleCooling().ShowDialog();
        }

        private void ButtonAuto_Click(object sender, EventArgs e)
        {
            timer1.Start();
            SetButtonsCoolor(CoolingTypes.Auto);
            FillValuesOnAuto();

        }

        private void btnOnOffLiving_CheckedChanged(object sender, EventArgs e)
        {
            if (btnOnOffLiving.Checked)
                lmhLivingRoom.Show();
            else
                lmhLivingRoom.Hide();
        }

        private void btnOnOffKichen_CheckedChanged(object sender, EventArgs e)
        {
            if (btnOnOffKichen.Checked)
                lmhKichen.Show();
            else
                lmhKichen.Hide();
        }

        private void btnOnOffBed_CheckedChanged(object sender, EventArgs e)
        {
            if (btnOnOffBed.Checked)
                lmhBed.Show();
            else
                lmhBed.Hide();
        }

        private void btnOnOffBath_CheckedChanged(object sender, EventArgs e)
        {
            if (btnOnOffBath.Checked)
                lmhBath.Show();
            else
                lmhBath.Hide();
        }

        private void btnOnOffDinning_CheckedChanged(object sender, EventArgs e)
        {
            if (btnOnOffDinning.Checked)
                lmhDining.Show();
            else
                lmhDining.Hide();
        }

        private void btnOnOffKids_CheckedChanged(object sender, EventArgs e)
        {
            if (btnOnOffKids.Checked)
                lmhKids.Show();
            else
                lmhKids.Hide();
        }

        private void ButtonEconomy_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lmhBath.Hide();
            btnOnOffBath.Checked = false;
            lmhLivingRoom.SetValue(LMH.Low);
            lmhLivingRoom.Show();
            btnOnOffLiving.Checked = true;
            lmhDining.SetValue(LMH.Low);
            lmhDining.Show();
            btnOnOffDinning.Checked = true;
            lmhBed.Hide();
            btnOnOffBed.Checked = false;
            lmhKids.Hide();
            btnOnOffKids.Checked = false;
            lmhKichen.Hide();
            btnOnOffKichen.Checked = false;
            SetButtonsCoolor(CoolingTypes.Economy);
            
        }

        

        private void btnColingOff_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lmhBath.Hide();
            btnOnOffBath.Checked = false;
            lmhLivingRoom.Hide();
            btnOnOffLiving.Checked = false;
            lmhDining.Hide();
            btnOnOffDinning.Checked = false;
            lmhBed.Hide();
            btnOnOffBed.Checked = false;
            lmhKids.Hide();
            btnOnOffKids.Checked = false;
            lmhKichen.Hide();
            btnOnOffKichen.Checked = false;
            SetButtonsCoolor(CoolingTypes.Off);
        }



        public void SetButtonsCoolor(CoolingTypes value)
        {
            CoolingType.CoolingTypeNow = value;
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

        private void btnCustom_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            SetButtonsCoolor(CoolingTypes.Custom);
        }

        private void lmhKichen_MouseClick(object sender, MouseEventArgs e)
        {
            checkClosingFormToFillCustomData();
        }

        private void checkClosingFormToFillCustomData()
        {
            if (CoolingType.CoolingTypeNow == CoolingTypes.Custom)
            {
                CustomValuesOnCooling.BathRoom = new CoolingRoom
                {
                    IsActive = btnOnOffBath.Checked,
                    Value = lmhBath.Value
                };
                CustomValuesOnCooling.DiningRoom = new CoolingRoom
                {
                    IsActive = btnOnOffDinning.Checked,
                    Value = lmhDining.Value
                };
                CustomValuesOnCooling.BedRoom = new CoolingRoom
                {
                    IsActive = btnOnOffBed.Checked,
                    Value = lmhBed.Value
                };
                CustomValuesOnCooling.Kichen = new CoolingRoom
                {
                    IsActive = btnOnOffKichen.Checked,
                    Value = lmhKichen.Value
                };
                CustomValuesOnCooling.KidsRoom = new CoolingRoom
                {
                    IsActive = btnOnOffKids.Checked,
                    Value = lmhKids.Value
                };
                CustomValuesOnCooling.LivingRoom = new CoolingRoom
                {
                    IsActive = btnOnOffLiving.Checked,
                    Value = lmhLivingRoom.Value
                };
            }
        }

        private void frmCooling_FormClosing(object sender, FormClosingEventArgs e)
        {
            checkClosingFormToFillCustomData();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(CoolingType.CoolingTypeNow == CoolingTypes.Auto)
            {
                FillValuesOnAuto();
            }
        }

        private void FillValuesOnAuto()
        {
                lmhBath.Hide();
                btnOnOffBath.Checked = false;
                lmhLivingRoom.Hide();
                btnOnOffLiving.Checked = false;
                lmhDining.Hide();
                btnOnOffDinning.Checked = false;
                lmhBed.Hide();
                btnOnOffBed.Checked = false;
                lmhKids.Hide();
                btnOnOffKids.Checked = false;
                lmhKichen.Hide();
                btnOnOffKichen.Checked = false;
                DateTime newDateTime = new DateTime(2010,10,10, DateTime.Now.Hour, DateTime.Now.Minute, 0);
                foreach(var item in Scheduled.scheduledCoolingRooms)
                {
                    if(newDateTime > item.From && newDateTime < item.To && item.IsActive && DateTime.Now.DayOfWeek == item.Day)
                    {
                        checkScheduledRoomAndSetValues(item);
                    }
                }
            
        }

        private void checkScheduledRoomAndSetValues(ScheduledCoolingRoom room)
        {
            switch (room.Room)
            {
                case RoomType.LivingRoom:
                    {
                        btnOnOffLiving.Checked = room.IsActive;
                        lmhLivingRoom.SetValue(room.Value);
                        break;
                    }
                case RoomType.BathRoom:
                    {

                        btnOnOffBath.Checked = room.IsActive;
                        lmhBath.SetValue(room.Value);
                        break;
                    }
                case RoomType.DiningRoom:
                    {
                        btnOnOffDinning.Checked = room.IsActive;
                        lmhDining.SetValue(room.Value);
                        break;
                    }
                case RoomType.KidsRoom:
                    {
                        btnOnOffKids.Checked = room.IsActive;
                        lmhKids.SetValue(room.Value);
                        break;
                    }
                case RoomType.Kichen:
                    {
                        btnOnOffKichen.Checked = room.IsActive;
                        lmhKichen.SetValue(room.Value);
                        break;
                    }
                case RoomType.BedRoom:
                    {
                        btnOnOffBed.Checked = room.IsActive;
                        lmhBed.SetValue(room.Value);
                        break;
                    }
            }
        }

        private void btnOnOffLiving_Click(object sender, EventArgs e)
        {
            SetButtonsCoolor(CoolingTypes.Custom);
        }
        
    }
}
