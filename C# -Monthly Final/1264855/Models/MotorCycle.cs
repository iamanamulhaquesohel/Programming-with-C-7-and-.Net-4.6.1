using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1264855.Models
{
    public sealed class MotorCycle : TwoWheeler, IExteriorFeature
    {
        private string[] Feature { get; set; }
        public void AddFeature(string[] feature)
        {
            this.Feature = feature;
        }

        public string GetFeature()
        {
            return string.Join(",", this.Feature);
        }
        public override string ToString()
        {
            return base.ToString()
                + "\n" +
                $"Feature: {GetFeature()}";
        }
    }
}
