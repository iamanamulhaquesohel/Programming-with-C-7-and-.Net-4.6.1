using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1264855.Models
{
    public class FourWheeler : Vehicle
    {
        public FourWheeler() { this.Wheels = 4; }
        public FourWheeler(string model, int make,int seat, int gear, int door, int cc,  VehicleType type) : base(model, make, seat, gear, door, cc, type)
        {
            this.Wheels = 4;
        }
    }
}
