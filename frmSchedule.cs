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
    public partial class frmSchedule : Form
    {
        private Day selectedDay; 
        public frmSchedule()
        {
            
            InitializeComponent();
           
        }

        private void frmSchedule_Load(object sender, EventArgs e)
        {
            selectedDay = Day.Monday;
            FillTheGrid();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEvent eve = new frmEvent(selectedDay, FillTheGrid);
            eve.Show();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            metroGrid1.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void btnMonday_Click(object sender, EventArgs e)
        {
            selectedDay = Day.Monday;
            metroGrid1.Rows.Clear();
            FillTheGrid();
            
        }
        public void FillTheGrid()
        {
            metroGrid1.Rows.Clear();
            foreach (var item in ScheduledCooling.schduledRooms)
            {
                if (item.Day == selectedDay)
                {
                    metroGrid1.Rows.Add(ScheduledCooling.schduledRooms.IndexOf(item), getStringFromDates(item.From, item.To), item.Value.ToString() + " °C", item.IsActive, item.Room.ToString());
                }
            }
        }

        private string getStringFromDates(DateTime from, DateTime to)
        {
            return String.Format("{0}:{1}  -  {2}:{3}", from.Hour.ToString("00"), from.Minute.ToString("00"), to.Hour.ToString("00"), to.Minute.ToString("00"));
        }

        private void btnThursday_Click(object sender, EventArgs e)
        {
            selectedDay = Day.Thursday;
            FillTheGrid();
        }

        private void btnWednesday_Click(object sender, EventArgs e)
        {
            selectedDay = Day.Wednesday;
            FillTheGrid();
        }

        private void btnThuesday_Click(object sender, EventArgs e)
        {
            selectedDay = Day.Tuesday;
            FillTheGrid();
        }

        private void btnFriday_Click(object sender, EventArgs e)
        {
            selectedDay = Day.Friday;
            FillTheGrid();
        }

        private void btnSaturday_Click(object sender, EventArgs e)
        {
            selectedDay = Day.Saturday;
            FillTheGrid();
        }

        private void btnSunday_Click(object sender, EventArgs e)
        {
            selectedDay = Day.Sunday;
            FillTheGrid();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (metroGrid1.SelectedCells.Count > 0)
            {
                int selectedrowindex = metroGrid1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = metroGrid1.Rows[selectedrowindex];

                int id = Convert.ToInt32(Convert.ToString(selectedRow.Cells["Id"].Value));

                ScheduledCooling.schduledRooms.RemoveRange(id, 1);

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

                new frmEvent(selectedDay, FillTheGrid, true, id).Show();

            }
        }

        private void metroGrid1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (metroGrid1.SelectedCells.Count > 0)
            {
                int selectedrowindex = metroGrid1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = metroGrid1.Rows[selectedrowindex];

                int id = Convert.ToInt32(Convert.ToString(selectedRow.Cells["Id"].Value));

                ScheduledCooling.schduledRooms[id].IsActive = Convert.ToBoolean(Convert.ToString(selectedRow.Cells["Active"].Value));

            }
        }

        

    }
}
