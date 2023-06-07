using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Day_C_prgs
{
    internal class Program
    {

               static void Main(string[] args)
        {
            datetimedifference();
            #region Datetime
            //DateTime date = new DateTime(2023,06,7);
            //Console.WriteLine(date.ToString());

            //DateTime date1 = new DateTime(2023, 06, 7,9,20,15);
            //Console.WriteLine(date1.ToString());

            //DateTime today=DateTime.Now;
            //Console.WriteLine(today.ToString());

            //// program to get 
            //DateTime d1 = new DateTime(2023, 02, 07);
            //DateTime d2 = new DateTime(2023, 02, 08);
            //TimeSpan time=d2-d1;
            //Console.WriteLine(time.ToString());


            //DateTime date1 = new DateTime(2023, 06, 7);
            //Console.WriteLine(date1);

            //DateTime date2 = new DateTime(2023, 06, 7, 10, 24, 35);
            //Console.WriteLine(date2);
            //DateTime today = DateTime.Now;
            //Console.WriteLine(today);

            //DateTime date3 = today.AddDays(10);
            //Console.WriteLine(date3);

            ////difference between 2 dates
            //DateTime dat1 = new DateTime(2023, 1, 4);
            //DateTime dat2 = new DateTime(2023, 2, 5);
            //TimeSpan dif = dat2 - dat1;
            //Console.WriteLine(dif);

            //TimeSpan diff1 = dat2.Subtract(dat1);
            //Console.WriteLine(diff1);

            //Console.WriteLine("Enter check in date1: ");
            //string dateTime1 = Console.ReadLine();
            //Console.WriteLine("Enter check in date2: ");
            //string dateTime2 = Console.ReadLine();
            //DateTime d1 = Convert.ToDateTime(dateTime1);
            //DateTime d2 = Convert.ToDateTime(dateTime2);
            //Console.WriteLine(d1.ToString());
            //Console.WriteLine(d2.ToString());
            //if (d1 > d2)
            //{
            //    TimeSpan diff = d1.Subtract(d2);
            //    Console.WriteLine(diff.ToString());
            //}
            //else
            //{
            //    Console.WriteLine("checkout date1 greater than date2");
            //}
            #endregion

            //functions1();
            //static void functions1()
            //{
            //    Console.WriteLine("functions1 Static view");
            //}

         //FunctionPointerAttributes
          static void datetimedifference()
            {
                DateTime dat1 = new DateTime(2023, 1, 4);
                DateTime dat2 = new DateTime(2023, 2, 5);
                TimeSpan dif = dat2 - dat1;
                Console.WriteLine(dif);
            }
        }
    }
}