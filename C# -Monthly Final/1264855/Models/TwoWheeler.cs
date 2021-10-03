using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1264855.Models
{
    public class TwoWheeler : Vehicle
    {
        public TwoWheeler() { this.Wheels = 2; }
        public TwoWheeler(string model, int make, int seat, int gear, int door, int cc, VehicleType type) : base ( model,  make, seat, gear,door, cc,  type)
        {
            this.Wheels = 2;
        }
    }
}
