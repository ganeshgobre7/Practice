using System;

namespace FileIODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WelCome to FileIO");
            FileDemo file = new FileDemo();
           /* file.CheckFile();
            file.ReadFile();*/
            file.WriteFile();
            file.CopyFile();
           
         
        }
    }
}
