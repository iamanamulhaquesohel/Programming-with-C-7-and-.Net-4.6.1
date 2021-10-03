using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_01.Entities
{
    public class SpecificBehavior<T> : ISpecificBehavior<T>
    {
        public string GetSpecificBehavior<T>(T Data) where T : Animal
        {
            switch (Data.Type)
            {
                case AnimalType.Harvivore:
                    return "Docile, Plant Eaters";
                case AnimalType.Carvivore:
                    return "Canine, Meat Eaters";
                case AnimalType.Omnivore:
                    return "Adaptable, Eating Everything Eatable";
                default:
                    return "Unknown Animal Type";
            }
        }
    }
}
