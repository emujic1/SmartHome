using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartHome
{
    public class ScheduledRoom
    {
        public Day Day { get; set; }
        public int Value { get; set; }
        public bool IsActive { get; set; }
        public RoomType Room { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}
