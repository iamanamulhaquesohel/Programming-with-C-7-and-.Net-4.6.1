using Evidence_01.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal A1 = new Animal("Horse", 3, AnimalType.Harvivore, Gender.Male);
            GenericBehavior<Animal> GB = new GenericBehavior<Animal>();
            Console.WriteLine(GB.GetGenericBehavior<Animal>(A1));
            SpecificBehavior<Animal> SB = new SpecificBehavior<Animal>();
            Console.WriteLine(SB.GetSpecificBehavior<Animal>(A1));
            Console.WriteLine();

            Animal A2 = new Animal("Dog", 4, AnimalType.Carvivore, Gender.Female);
            GenericBehavior<Animal> GB2 = new GenericBehavior<Animal>();
            Console.WriteLine(GB2.GetGenericBehavior<Animal>(A2));
            SpecificBehavior<Animal> SB2 = new SpecificBehavior<Animal>();
            Console.WriteLine(SB2.GetSpecificBehavior<Animal>(A2));


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to Exit the Program");
            Console.ReadKey();
        }//Main

    }//Class
    
}//Namespace