using System;
using System.Diagnostics;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////
            ////Console.WriteLine("Hello World!");
            //Console.WriteLine("Enter your Name : ");
            //string name = Console.ReadLine();

            //if (name == "narendra")
            //{
            //    Console.WriteLine("Hello");
            //}

            //else

            //{
            //    Console.WriteLine("bye");
            //}
            Console.WriteLine("Enter first number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number : ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter operator number :(+ , -, * ,/,%) ");
            char op = char.Parse(Console.ReadLine());
            //if (op == '+')
            //{
            //    Console.WriteLine("Addition result is : " + (num1 + num2));

            //}
            //else if (op == '-')
            //{
            //    Console.WriteLine("Subtraction result is : " + (num1 - num2));
            //}
            //else  if(op == '*')
            //{
            //    Console.WriteLine("Multiplication result is : " + (num1 * num2));
            //}

            //else if (op == '/')
            //{
            //    Console.WriteLine("Dividion result is : " + (num1 / num2));
            //}
            //else if (op == '%')
            //{
            //    Console.WriteLine("Modulus result is : " + (num1 % num2));
            //}

            switch (op)
            {
                case '+': Console.WriteLine("Addition result is : " + (num1 + num2));
                    break;
                case '-': Console.WriteLine("Subtraction result is : " + (num1 - num2));
                    break;
                case '/':
                    Console.WriteLine("Dividion result is : " + (num1 / num2));
                    break;
                case '%':
                    Console.WriteLine("modulus result is : " + (num1 % num2));
                    break;

                default: Console.WriteLine("Enter operator number: (+ , -, * ,/,%)");

                    break;

            }
        }
        }
    }

