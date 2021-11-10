using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1264855.Models
{
    public abstract class Vehicle
    {
        public Vehicle() { }
        public Vehicle(string model, int make,int seat, int gear,int door, int cc, VehicleType type)
        {
            this.Model = model;
            this.Make = make;
            this.Seat = seat;
            this.Gear = gear;
            this.Door = door;
            this.CC = cc;
            this.Type = type;
        }
        public string Model { get; set; }
        public int Make { get; set; }
        public int Seat { get; set; }
        public int Gear { get; set; }
        public int Door { get; set; }
        public int CC { get; set; }
        public VehicleType Type { get; set; }
        protected int Wheels { get; set; }

        public override string ToString()
        {
            return $"ModeL: {this.Model}\nMake: {this.Make}\nCC: {CC}\nType: {this.Type}\n" +
                $"Gear Type: {Gear}";
        }

    }
}
