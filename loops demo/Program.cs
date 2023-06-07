using System;

namespace loops_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine("For loop demo :");
            for(int i = 1; i<= 50; i++)
            {
                Console.WriteLine(i+ " ");
            }
            Console.WriteLine();
            Console.WriteLine("for even numbers ");
            for (int i = 0; i <= 50; i=i+1)
            {               
                if(i % 2 == 0)
                { 
                    Console.WriteLine(i + " ");
                }
               
            }
            Console.WriteLine("for odd numbers ");
            for (int i = 1; i <= 50; i = i + 1)
            {

                if (i % 2 != 0)
                {
                    Console.WriteLine(i + " ");
                }
            }
                Console.WriteLine("for divided by 5 numbers ");
                for (int i = 1; i <= 50; i = i + 1)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine(i + " ");
                    }
                }

            Console.WriteLine("for while demo :");
            int a = 20;
            while (a<50)
            {
                Console.Write(a + " ");
                a++;
            }
            // do ... while loop

            Console.WriteLine(" for do while  demo :");
            int b= 10;
            do
            {
                Console.WriteLine(" WELCOME TO Dell Batch");
               // b = b++;
            }
            while (b == 100);
            //goto demo
            Console.WriteLine(" go to loops");
            for (int i = 1; i <= 50; i = i + 1)
            {
                if (i == 5) ;
                {
                    goto Dell;
                }
            }
            Dell: Console.WriteLine(" Hello DELL");

        }
       

    }
}

