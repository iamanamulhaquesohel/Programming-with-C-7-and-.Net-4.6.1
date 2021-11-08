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
            Console.WriteLine($"Question: 6-A => ALL DECISION AND ITERATION STATEMENT(IF-ELSE, SWITCH, WHILE, FOR, FOREACH, DO).");
            Console.WriteLine("=================================================================================================");
            Console.WriteLine($"----ANSWER TO THE QUESTION NO 6-A----");
            Console.WriteLine();
            If_Statement();
            Console.WriteLine();
            If_Else_Statement();
            Console.WriteLine();
            If_Else_If_Statement();
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
            Console.WriteLine($"Question: 6-B => DECLARING, NAMING & ASSIGNING VARIABLE, USING PRIMITIVE DATA TYPES, ARITHMETIC OPERATORS, DIFFERENCE OF PREFIX & POSTFIX, SCOPE.");
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine($"----ANSWER TO THE QUESTION NO 6-B----");
            Console.WriteLine();
            Assignment_Operators();
            Console.WriteLine();
            Using_Variables();
            Console.WriteLine();
            Operator_Precedence();
            Console.WriteLine();
            Pre_Post_Fix();
            Console.WriteLine();
            Premitive_Data_Types();
            Console.WriteLine();
            //END OF  THE QUESTION NO 6-B//

            //ANSWER TO THE QUESTION NO 6-C//
            //HANDLE EXCEPTION USING TRY CATCH FINALLY//
            Console.WriteLine($"Question: 6-C => HANDLE EXCEPTION USING TRY CATCH FINALLY.");
            Console.WriteLine("============================================================");
            Console.WriteLine($"----ANSWER TO THE QUESTION NO 6-C----");
            Console.WriteLine();

            //STARTING TRY CATCH
            try
            {
                Console.WriteLine("Enter First Value:");
                int firstNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Value:");
                int secondNumber = int.Parse(Console.ReadLine());
                int result = firstNumber / secondNumber;
                Console.WriteLine($"Result = {result}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Input string was not in correct format. ");
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

        //If-Statement
        static void If_Statement() 
        {
            Console.WriteLine($"-------If Statement-------");
            int x = 20, y = 10;
            if (x >= 10)
            {
                Console.WriteLine("x is greater than 10");
            }
            if (y <= 5)
            {
                Console.WriteLine("y is less than or equals to 5");
            }
        }
        //If-Else Statement
        static void If_Else_Statement() 
        {
            Console.WriteLine($"------- If-Else Statement-------");
            int x = 20;
            if (x >= 10)
            {
                Console.WriteLine("x is Greater than or equals to 10");
            }
            else
            {
                Console.WriteLine("x is less than 10");
            }
        }
        //If-Else-If Statement
        static void If_Else_If_Statement() 
        {
            Console.WriteLine($"----- If-Else-If Statement-----");
            int x = 10;
            if (x == 10)
            {
                Console.WriteLine("x value is equals to 10");
            }
            else if (x > 10) 
            {
                Console.WriteLine("x value is greater than 10");
            }
            else
            {
                Console.WriteLine("x value is less than 10");
            }
        }
        //Switch Case Statement
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

        //For Loop Statement
        static void For_loop_Statement() 
        {
            Console.WriteLine($"----- For-Loop Statement-----");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("i value is: {0}", i);
            }
        }

        //While Loop Statement
        static void While_loop_Statement() 
        {
            Console.WriteLine($"----- While-Loop Statement-----");
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine("i value: {0}", i);
                i++;
            }
        }

        //Do While Loop Statement
        static void Do_While_loop_Statement() 
        {
            Console.WriteLine($"-----Do-While-Loop Statement-----");
            int i = 1;
            do
            {
                Console.WriteLine("i value: {0}", i);
                i++;
            } 
            while (i <= 5);
        }

        //Assignment Operator
        static void Assignment_Operators() 
        {
            Console.WriteLine($"-----Assignment Operators-----");
            int x = 20;
            x += 10;
            Console.WriteLine("Add Assignment: " + x);
            x *= 4;
            Console.WriteLine("Multiply Assignment: " + x);
            x %= 7;
            Console.WriteLine("Modulo Assignment: " + x);
            x &= 16;
            Console.WriteLine("Bitwise And Assignment: " + x);
            x ^= 12;
            Console.WriteLine("Bitwise XOR Assignment: " + x);
            x >>= 3;
            Console.WriteLine("Right Shift Assignment: " + x);
        }

        //Using Variablles
        static void Using_Variables() 
        {
            Console.WriteLine($"-----Variables Declaration-----");
            Console.WriteLine("Global Variable:");
            dateExam = new DateTime(2021, 6, 24); //assignment
            Console.WriteLine($"Exam Date: {dateExam:yyyy-MM-dd}");
            Console.WriteLine();
            Console.WriteLine("Local Variable:");
            string course = "OL-WADA";
            float pi = 3.10F;
            decimal wage = 9000.75M;
            Console.WriteLine($"Course: {course}");
            Console.WriteLine($"PI: {pi}");
            Console.WriteLine($"Wage: {wage}");
        }

        //Operator Precedence
        static void Operator_Precedence() 
        {
            Console.WriteLine($"----- Operator Precedence-----");
            int x = 20, y = 5, z = 4;
            int result = x / y + z;
            Console.WriteLine("Result 1: " + result);
            bool result2 = z <= y + x;
            Console.WriteLine("Result 2: " + result2);
        }

        //Pre fix & Post Fix
        static void Pre_Post_Fix() 
        {
            Console.WriteLine($"----- PreFix  & PostFix-----");
            Console.WriteLine("Pre Fix:");
            int x = 10;
            Console.WriteLine($"x= {x}");
            int m = ++x; //prefix
            Console.WriteLine($"m= {m}");
            Console.WriteLine($"x= {x}");
            Console.WriteLine("Post Fix:");
            int n = x++; //postfix
            Console.WriteLine($"n= {n}");
            Console.WriteLine($"x= {x}");
        }

        //Premitive Data Types
        static void Premitive_Data_Types() 
        {
            Console.WriteLine($"----- Premitive Data Types-----");
            Console.WriteLine("Int, String, Double, Char, Bool Data Type:");
            Console.WriteLine();
            int number = 10;
            string name = "Anamul Haque Sohel";
            double percentage = 10.24;
            char gender = 'M';
            bool isVerified = true;
            Console.WriteLine("int = " + number);
            Console.WriteLine("string = " + name);
            Console.WriteLine("double = " + percentage);
            Console.WriteLine("char = " + gender);
            Console.WriteLine("bool = " + isVerified);
        }


    }//Class or Program

}//Namespace
