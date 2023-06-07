using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// Console.Write( "welcome to c# --Dell Batch ");
            // Console.Write("welcome again");
            //// Console.Read(); // enter to exit // 
            /////Console.ReadLine(); //
            ///enter to exit 
            ///// Console.ReadKey(); 
            ///// any key to exit //
            ///// camel case, upper case, lower case, sentence case //
            ///// taking the input Console.WriteLine( "Enter first number : "); 
            ///// data types : int, char, float, double, string............ 
            Console.WriteLine("Enter first number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number : ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Addition result is : " + (num1 + num2));
            Console.WriteLine("Subtraction result is : " + (num1 - num2));
            Console.WriteLine("Multiplication result is : " + (num1 * num2));
        }
    }
}
