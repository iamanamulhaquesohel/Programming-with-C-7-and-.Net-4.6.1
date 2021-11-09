using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Evidence_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 9, 6, 5, 8 };
            for (var i = 0; i < numbers.Length; i++)
            {
                CallSum((i + 1) * 5, $"1 + 2 + ... + {(i + 1) * 5} = ");
            }
            Console.WriteLine("Wait!! Calculating.........");

            Console.WriteLine();
            Console.ReadLine();
        }//Main

        //CALL SUM 
        public static async void CallSum(int xValue, string label)
        {
            await Task<int>.Run(() =>
            {
                SumAsync(xValue).ContinueWith(t => Console.WriteLine($"{label}{t.Result}"));
            });
        }

        //SUM ASYNC
        public static async Task<int> SumAsync(int n)
        {
            Random RandomNumber = new Random();
            int sum = 0;
            Console.WriteLine($"Task: {Thread.CurrentThread.ManagedThreadId} Starts Calculating Sum of 1 + 2 + .. + {n}...");
            await Task.Run(() =>
            {
                for (var i = 1; i <= n; i++)
                {
                    sum += i;
                    Task.Delay(RandomNumber.Next(1, 300)).Wait();
                }
            });
            return sum;
        }
    }//Class
}//Namespace
