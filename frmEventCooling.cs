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
    public partial class frmEventCooling : Form
    {
        private DayOfWeek setToDay;
        private Action fillGrid;
        bool isEdit;
        int idEditRoom;

        public frmEventCooling(DayOfWeek day, Action fillData, bool edit = false, int id = 0)
        {
            isEdit = edit;
            idEditRoom = id;
            fillGrid = fillData;
            setToDay = day;
            InitializeComponent();
        }

        private void frmEventCooling_Load(object sender, EventArgs e)
        {
            comboRoom.SelectedIndex = 0;
            dateTimePicker2.Value = dateTimePicker1.Value.AddHours(1);
            comboValue.SelectedIndex = 0;
            if (isEdit)
            {
                dateTimePicker1.Value = Scheduled.scheduledCoolingRooms[idEditRoom].From;
                dateTimePicker2.Value = Scheduled.scheduledCoolingRooms[idEditRoom].To;
                comboValue.SelectedIndex = (int)Scheduled.scheduledCoolingRooms[idEditRoom].Value;
                comboRoom.SelectedIndex = (int)Scheduled.scheduledCoolingRooms[idEditRoom].Room;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (isEdit)
            {
                Scheduled.scheduledCoolingRooms[idEditRoom].From = new DateTime(2010,10,10,dateTimePicker1.Value.Hour,dateTimePicker1.Value.Minute,0);
                Scheduled.scheduledCoolingRooms[idEditRoom].To = new DateTime(2010, 10, 10, dateTimePicker2.Value.Hour, dateTimePicker2.Value.Minute, 0);
                Scheduled.scheduledCoolingRooms[idEditRoom].Value = (LMH)comboValue.SelectedIndex;
                Scheduled.scheduledCoolingRooms[idEditRoom].Room = (RoomType)comboRoom.SelectedIndex;
            }
            else
            {
                ScheduledCoolingRoom schdRoom = new ScheduledCoolingRoom()
                {
                    Value = (LMH)comboValue.SelectedIndex,
                    From = new DateTime(2010,10,10,dateTimePicker1.Value.Hour,dateTimePicker1.Value.Minute,0),
                    To = new DateTime(2010, 10, 10, dateTimePicker2.Value.Hour, dateTimePicker2.Value.Minute, 0),
                    Day = setToDay,
                    IsActive = true,
                    Room = (RoomType)comboRoom.SelectedIndex
                };
                Scheduled.scheduledCoolingRooms.Add(schdRoom);
            }
            this.Close();
        }

        private void frmEventCooling_FormClosing(object sender, FormClosingEventArgs e)
        {
            fillGrid();
        }

    }
}
