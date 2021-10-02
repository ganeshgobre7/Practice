using System;

namespace UnitTestingPractice
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO UNIT TESTING");
            ArithmeticOperation operation = new ArithmeticOperation();
            Console.WriteLine(operation.Add(10, 20));
            Console.WriteLine(operation.Sub(20, 30));
            Console.WriteLine(operation.Mul(20, 30));
            Console.WriteLine(operation.Div(20, 10));
        }
    }
}
