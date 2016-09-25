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
    public partial class frmSchaduleCooling : Form
    {
        private DayOfWeek selectedDay; 
        public frmSchaduleCooling()
        {
            InitializeComponent();
        }

        private void frmSchaduleCooling_Load(object sender, EventArgs e)
        {
            btnAdd.DisplayFocus = true;
            selectedDay = DateTime.Now.DayOfWeek;
            CheckButtonsColor(selectedDay);
            FillTheGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEventCooling eve = new frmEventCooling(selectedDay, FillTheGrid);
            eve.ShowDialog();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            metroGrid1.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void btnMonday_Click(object sender, EventArgs e)
        {
            selectedDay = DayOfWeek.Monday;
            CheckButtonsColor(selectedDay);
            FillTheGrid();
            
        }
        public void FillTheGrid()
        {
            metroGrid1.Rows.Clear();
            foreach (var item in Scheduled.scheduledCoolingRooms)
            {
                if (item.Day == selectedDay)
                {
                    metroGrid1.Rows.Add(Scheduled.scheduledCoolingRooms.IndexOf(item), getStringFromDates(item.From, item.To), item.Value.ToString(), item.IsActive, item.Room.ToString());
                }
            }
        }

        private string getStringFromDates(DateTime from, DateTime to)
        {
            return String.Format("{0}:{1}  -  {2}:{3}", from.Hour.ToString("00"), from.Minute.ToString("00"), to.Hour.ToString("00"), to.Minute.ToString("00"));
        }

        private void btnThursday_Click(object sender, EventArgs e)
        {
            selectedDay = DayOfWeek.Thursday;
            CheckButtonsColor(selectedDay);
            FillTheGrid();
        }

        private void btnWednesday_Click(object sender, EventArgs e)
        {
            selectedDay = DayOfWeek.Wednesday;
            CheckButtonsColor(selectedDay);
            FillTheGrid();
        }

        private void btnThuesday_Click(object sender, EventArgs e)
        {
            selectedDay = DayOfWeek.Tuesday;
            CheckButtonsColor(selectedDay);
            FillTheGrid();
        }

        private void btnFriday_Click(object sender, EventArgs e)
        {
            selectedDay = DayOfWeek.Friday;
            CheckButtonsColor(selectedDay);
            FillTheGrid();
        }

        private void btnSaturday_Click(object sender, EventArgs e)
        {
            selectedDay = DayOfWeek.Saturday;
            CheckButtonsColor(selectedDay);
            FillTheGrid();
        }

        private void btnSunday_Click(object sender, EventArgs e)
        {
            selectedDay = DayOfWeek.Sunday;
            CheckButtonsColor(selectedDay);
            FillTheGrid();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (metroGrid1.SelectedCells.Count > 0)
            {
                int selectedrowindex = metroGrid1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = metroGrid1.Rows[selectedrowindex];

                int id = Convert.ToInt32(Convert.ToString(selectedRow.Cells["Id"].Value));

                Scheduled.scheduledCoolingRooms.RemoveRange(id, 1);

                FillTheGrid();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (metroGrid1.SelectedCells.Count > 0)
            {
                int selectedrowindex = metroGrid1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = metroGrid1.Rows[selectedrowindex];

                int id = Convert.ToInt32(Convert.ToString(selectedRow.Cells["Id"].Value));

                new frmEventCooling(selectedDay, FillTheGrid, true, id).ShowDialog();

            }
        }

        private void metroGrid1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (metroGrid1.SelectedCells.Count > 0)
            {
                int selectedrowindex = metroGrid1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = metroGrid1.Rows[selectedrowindex];

                int id = Convert.ToInt32(Convert.ToString(selectedRow.Cells["Id"].Value));

                Scheduled.scheduledCoolingRooms[id].IsActive = Convert.ToBoolean(Convert.ToString(selectedRow.Cells["Active"].Value));

            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckButtonsColor(DayOfWeek day)
        {
            btnMonday.BackColor = Color.Gainsboro;
            btnThursday.BackColor = Color.Gainsboro;
            btnWednesday.BackColor = Color.Gainsboro;
            btnTuesday.BackColor = Color.Gainsboro;
            btnFriday.BackColor = Color.Gainsboro;
            btnSunday.BackColor = Color.Gainsboro;
            btnSaturday.BackColor = Color.Gainsboro;
            switch(day)
            {
                case DayOfWeek.Monday:
                    {
                        btnMonday.BackColor = Color.DimGray;
                        break;
                    }
                case DayOfWeek.Tuesday:
                    {
                        btnTuesday.BackColor = Color.DimGray;
                        break;
                    }
                case DayOfWeek.Wednesday:
                    {
                        btnWednesday.BackColor = Color.DimGray;
                        break;
                    }
                case DayOfWeek.Thursday:
                    {
                        btnThursday.BackColor = Color.DimGray;
                        break;
                    }
                case DayOfWeek.Friday:
                    {
                        btnFriday.BackColor = Color.DimGray;
                        break;
                    }
                case DayOfWeek.Saturday:
                    {
                        btnSaturday.BackColor = Color.DimGray;
                        break;
                    }
                case DayOfWeek.Sunday:
                    {
                        btnSunday.BackColor = Color.DimGray;
                        break;
                    }
            }

        }

        
    }
}
