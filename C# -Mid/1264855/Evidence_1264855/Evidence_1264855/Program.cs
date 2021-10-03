using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_1264855
{
    class Program
    {
        static DateTime dateExam;
        static void Main(string[] args)
        {
            //ANSWER TO THE QUESTION NO 6-A//
            //ALL DECISION AND ITERATION STATEMENT//
            Console.WriteLine($"----ANSWER TO THE QUESTION NO 6-A----");
            If_Statement();
            Console.WriteLine();
            If_Else_Statement();
            Console.WriteLine();
            If_else_If_Statement();
            Console.WriteLine();
            Switch_Case_Statement();
            Console.WriteLine();
            For_loop_Statement();
            Console.WriteLine();
            While_loop_Statement();
            Console.WriteLine();
            Do_While_loop_Statement();
            Console.WriteLine();
            //END OF THE ALL DECISION AND ITERATION STATEMENT//


            //ANSWER TO THE QUESTION NO 6-B//
            //DECLARING, NAMING & ASSIGNING VARIABLE, USING PRIMITIVE DATA TYPE//
            //ARITHMETIC OPERATOR, DIFFERENCE OF PREFIX AND POSTFIX, SCOPE//
            Console.WriteLine($"----ANSWER TO THE QUESTION NO 6-B----");
            Console.WriteLine();
            AssignmentOperator();
            Console.WriteLine();
            UsingVariables();
            Console.WriteLine();
            PrePostFix();
            Console.WriteLine();
            OperatorPrecedence();
            Console.WriteLine();
            Premitive_Data_Type();
            Console.WriteLine();
            //END OF  THE QUESTION NO 6-B//


            //ANSWER TO THE QUESTION NO 6-C//
            //HANDLE EXCEPTION USING TRY CATCH FINALLY//
            Console.WriteLine($"----ANSWER TO THE QUESTION NO 6-C----");
            Console.WriteLine();
            //STARTING TRY CATCH//
            try
            {
                Console.WriteLine("Enter First value:");
                int FirstNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second value:");
                int SecondNumber = int.Parse(Console.ReadLine());
                int result = FirstNumber / SecondNumber;
                Console.WriteLine($"Result = {result}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Input string was not in a correct format.");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Not a valid numbers to perform operation");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot Divided By Zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Occured");
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("Well Done !! Great JOb -By Anamul Haque Sohel-1264855.");
            }
            //END OF  THE QUESTION NO 6-C//





            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press Enter Any Key to Exit The Programe");
            Console.ReadKey(); //For Hold CMD or User input any key to Exit the Programe

        }//Main



        static void If_Statement()
        {
            Console.WriteLine($"----- IF Statement-----");
            int x = 20, y = 10;
            if (x >= 10)
            {
                Console.WriteLine("x is Greater than 10");
            }
            if (y <= 5)
            {
                Console.WriteLine("y is less than or equals to 5");
            }
        }

        static void If_Else_Statement()

        {
            Console.WriteLine($"----- IF Else Statement-----");
            int x = 20;
            if (x >= 10)
            {
                Console.WriteLine("x is Greater than or Equals to 10");
            }
            else
            {
                Console.WriteLine("x is Less than 10");
            }
        }

        static void If_else_If_Statement()
        {
            Console.WriteLine($"----- If Else IF Statement-----");
            int x = 5;
            if (x == 10)
            {
                Console.WriteLine("x value equals to 10");
            }
            else if (x > 10)
            {
                Console.WriteLine("x value greater than 10");
            }
            else
            {
                Console.WriteLine("x value less than 10");
            }
        }

        static void Switch_Case_Statement()

        {
            Console.WriteLine($"----- Switch Case Statement-----");
            int x = 20;
            switch (x)
            {
                case 10:
                    Console.WriteLine("x value is 10");
                    break;
                case 15:
                    Console.WriteLine("x value is 15");
                    break;
                case 20:
                    Console.WriteLine("x value is 20");
                    break;
                default:
                    Console.WriteLine("Not Known");
                    break;
            }
        }

        static void For_loop_Statement()
        {
            Console.WriteLine($"----- For Loop Statement-----");
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("I value is: {0}", i);
            }
        }

        static void While_loop_Statement()
        {
            Console.WriteLine($"----- While Loop Statement-----");
            int i = 1;
            while (i <= 4)
            {
                Console.WriteLine("i value: {0}", i);
                i++;
            }
        }

        static void Do_While_loop_Statement()
        {
            Console.WriteLine($"-----Do While Loop Statement-----");
            int i = 1;
            do
            {
                Console.WriteLine("i value: {0}", i);
                i++;
            }
            while (i <= 4);
        }

        static void AssignmentOperator()
        {
            Console.WriteLine($"-----Assignment Operator-----");
            int x = 20;
            x += 10;
            Console.WriteLine("Add Assignment:  " + x);
            x *= 4;
            Console.WriteLine("Multiply Assignment: " + x);
            x %= 7;
            Console.WriteLine("Modulo Assignment: " + x);
            x &= 10;
            Console.WriteLine("Bitwise And Assignment: " + x);
            x ^= 12;
            Console.WriteLine("Bitwise XOR Assignment: " + x);
            x >>= 3;
            Console.WriteLine("Right Shift Assignment: " + x);
        }

        static void UsingVariables()
        {
            Console.WriteLine($"-----Variables Declaration-----");
            Console.WriteLine("Global Variable");
            dateExam = new DateTime(2021, 6, 24); //assignment
            Console.WriteLine($"Exam Date: {dateExam:yyyy-MM-dd}");
            Console.WriteLine("Local Variable");
            string course = "OL-WADA";
            float pi = 3.14F;
            decimal wage = 9000.75M;
            Console.WriteLine($"Course: {course}");
            Console.WriteLine($"PI: {pi}");
            Console.WriteLine($"Wage: {wage}");
        }

        static void OperatorPrecedence()
        {
            Console.WriteLine($"----- Operator Precedence-----");
            int x = 20, y = 5, z = 4;
            int result = x / y + z;
            Console.WriteLine("Result1: " + result);
            bool result2 = z <= y + x;
            Console.WriteLine("Result2: " + result2);
        }
        static void PrePostFix()
        {
            Console.WriteLine($"----- PreFix  & PostFix-----");
            Console.WriteLine("Pre Fix and Post Fix");
            int x = 10;
            Console.WriteLine($"x={x}");
            int m = ++x;//Prefix
            Console.WriteLine($"m={m}");
            Console.WriteLine($"x={x}");
            int n = x++;
            Console.WriteLine($"n={n}");
            Console.WriteLine($"x={x}");
        }

        static void Premitive_Data_Type()
        {
            Console.WriteLine($"----- Premitive Data Type-----");
            Console.WriteLine("Int, String, Double, Char, Bool Data Type");
            int number = 10;
            string name = "Suresh Dasari";
            double percentage = 10.23;
            char gender = 'M';
            bool isVerified = true;
        }



    }//Class or Program

}//Namespace
