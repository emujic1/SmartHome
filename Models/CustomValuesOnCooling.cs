using SmartHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public static class CustomValuesOnHeating
    {
        public static HeatingRoom Kichen { get; set; }
        public static HeatingRoom BedRoom { get; set; }
        public static HeatingRoom BathRoom { get; set; }
        public static HeatingRoom DiningRoom { get; set; }
        public static HeatingRoom KidsRoom { get; set; }
        public static HeatingRoom LivingRoom { get; set; }
    }

    public static class CustomValuesOnCooling
    {
        public static CoolingRoom Kichen { get; set; }
        public static CoolingRoom BedRoom { get; set; }
        public static CoolingRoom BathRoom { get; set; }
        public static CoolingRoom DiningRoom { get; set; }
        public static CoolingRoom KidsRoom { get; set; }
        public static CoolingRoom LivingRoom { get; set; }

    }
}
