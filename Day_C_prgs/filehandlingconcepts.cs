using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day_C_prgs
{
    public class filehandlingconcepts
    {
       
        public void doapp()
        {
        //    FileInfo fileInfo = new FileInfo("C:\\Users\\Narendra_Yellamarthi\\account.cfg");
        //    Console.WriteLine(fileInfo.FullName);
        //    Console.WriteLine(fileInfo.Extension);
        //    Console.WriteLine(fileInfo.Name);
        //    Console.WriteLine(fileInfo.CreationTime);
        //    Console.WriteLine(fileInfo.LastAccessTime);
        //    Console.WriteLine(fileInfo.LastWriteTime);
               
        
        //string root1 = "C:\\Users\\Narendra_Yellamarthi\\Documents";
        //string[] dirnames =Directory.GetDirectories(root1);

        // foreach(string dirname in dirnames)
        //    {
        //        Console.WriteLine("dir "+ dirname);
                
        //        Console.WriteLine(dirname.Replace("\\", "/"));
        //    }

            string dir = Directory.GetCurrentDirectory();
            string filename = dir + "data.txt";
            if(File.Exists(filename))
            {
                Console.WriteLine("file existed");
            }
            else
            {
                Console.WriteLine("file not found");
            }
            using(StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine(" first line");
                sw.WriteLine("second line");
                sw.WriteLine("third line");
                sw.WriteLine("fourth line");
                sw.WriteLine("fifth line");
            }
            Console.WriteLine(filename + " is created ");

        }
    }
}

