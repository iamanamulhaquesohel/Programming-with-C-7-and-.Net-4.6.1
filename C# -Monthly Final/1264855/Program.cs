using _1264855.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1264855
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car input");
            Car c = new Car();
            Console.Write("Model No: ");
            c.Model = Console.ReadLine();
            Console.Write("Year Make: ");
            c.Make = int.Parse(Console.ReadLine());
            Console.Write("Number of Seat: ");
            c.Seat = int.Parse(Console.ReadLine());
            Console.Write("Number of Gear: ");
            c.Gear = int.Parse(Console.ReadLine());
            Console.Write("Number of Door: ");
            c.Gear = int.Parse(Console.ReadLine());
            Console.Write("Engine Capacity in CC: ");
            c.CC = int.Parse(Console.ReadLine());
            Console.Write("Feature: ");
            string input = Console.ReadLine();
            c.AddFeature(input.Split(','));

            Console.WriteLine();
            Console.WriteLine("Motor Cycle input");
            Console.WriteLine();
            MotorCycle b = new MotorCycle();
            Console.Write("Model: NO: ");
            b.Model = Console.ReadLine();
            Console.Write("Year Make: ");
            b.Make = int.Parse(Console.ReadLine());
            Console.Write("Number of Gear: ");
            b.Gear = int.Parse(Console.ReadLine());
            Console.Write("Engine Capacity in CC: ");
            b.CC = int.Parse(Console.ReadLine());
            Console.Write("Feature: ");
            string input1 = Console.ReadLine();
            b.AddFeature(input1.Split(','));


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Car Output");
            Console.WriteLine("============");
            Console.WriteLine(c);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("MotorCycle Output");
            Console.WriteLine("=================");
            Console.WriteLine(b);
            Console.ReadLine();




        }//Main


    }//Program


}//Namespace
