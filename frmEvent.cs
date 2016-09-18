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
    public partial class frmEvent : Form
    {
        private Day setToDay;
        private Action fillGrid;
        bool isEdit;
        int idEditRoom;
        public frmEvent(Day day, Action fillData, bool edit = false, int id = 0)
        {
            isEdit = edit;
            idEditRoom = id;
            fillGrid = fillData;
            setToDay = day;
            InitializeComponent();
        }

        private void frmEvent_Load(object sender, EventArgs e)
        {
            metroComboBox1.SelectedIndex = 0;
            dateTimePicker2.Value = dateTimePicker1.Value.AddHours(1);
            textBox1.Text = "25";
            if (isEdit)
            {
                dateTimePicker1.Value = ScheduledCooling.schduledRooms[idEditRoom].From;
                dateTimePicker2.Value = ScheduledCooling.schduledRooms[idEditRoom].To;
                textBox1.Text = ScheduledCooling.schduledRooms[idEditRoom].Value.ToString();
                metroComboBox1.SelectedIndex = (int)ScheduledCooling.schduledRooms[idEditRoom].Room;
                btnAdd.Text = "Edit";
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if(dateTimePicker1.Value > dateTimePicker2.Value)
            {
                btnAdd.Visible = false;
                return;
            }
            btnAdd.Visible = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                btnAdd.Visible = false;
                return;
            }
            btnAdd.Visible = true;
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') )
            {
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (isEdit)
            {
                ScheduledCooling.schduledRooms[idEditRoom].From = dateTimePicker1.Value;
                ScheduledCooling.schduledRooms[idEditRoom].To = dateTimePicker2.Value;
                ScheduledCooling.schduledRooms[idEditRoom].Value = Convert.ToInt32(textBox1.Text.Substring(0, 2));
                checkSelectedRoom(ScheduledCooling.schduledRooms[idEditRoom]);
            }
            else
            {
                ScheduledRoom schdRoom = new ScheduledRoom()
                {
                    Value = Convert.ToInt32(textBox1.Text.Substring(0, 2)),
                    From = dateTimePicker1.Value,
                    To = dateTimePicker2.Value,
                    Day = setToDay,
                    IsActive = true
                };
                checkSelectedRoom(schdRoom);
                ScheduledCooling.schduledRooms.Add(schdRoom);
            }
            this.Close();
        }

        private void frmEvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            fillGrid();
        }
        private void checkSelectedRoom(ScheduledRoom schdRoom)
       {
           switch (metroComboBox1.SelectedIndex)
                {
                    case (int)RoomType.BathRoom:
                        {
                            schdRoom.Room = RoomType.BathRoom;
                            break;
                        }
                    case (int)RoomType.BedRoom:
                        {
                            schdRoom.Room = RoomType.BedRoom;
                            break;
                        }
                    case (int)RoomType.DiningRoom:
                        {
                            schdRoom.Room = RoomType.DiningRoom;
                            break;
                        }
                    case (int)RoomType.Kichen:
                        {
                            schdRoom.Room = RoomType.Kichen;
                            break;
                        }
                    case (int)RoomType.KidsRoom:
                        {
                            schdRoom.Room = RoomType.KidsRoom;
                            break;
                        }
                    case (int)RoomType.LivingRoom:
                        {
                            schdRoom.Room = RoomType.LivingRoom;
                            break;
                        }
                }
       }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 2 && Convert.ToInt32(textBox1.Text.Substring(0,1)) > 3)
            {
                textBox1.Text = textBox1.Text.Substring(0, 1);
                return;
            }
            if(textBox1.Text.Length >2)
            {
                textBox1.Text = textBox1.Text.Substring(0, 2);
                return;
            }
            if(textBox1.Text.Length == 0)
            {
                btnAdd.Visible = false;
                return;
            }
            btnAdd.Visible = true;
        }
    }
}
