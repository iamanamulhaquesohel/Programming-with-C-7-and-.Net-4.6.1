using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_01.Entities
{
    public class GenericBehavior<T> : IGenericBehavior<T>
    {
        public string GetGenericBehavior<T>(T Data)
        {
            if (Data is Animal)
            {
                Animal a = Data as Animal;
                switch (a.Type)
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
            else
            {
                return "Unknown Type";
            }
        }
    }
}
