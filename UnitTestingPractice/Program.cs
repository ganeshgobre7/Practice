using System;

namespace UnitTestingPractice
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO UNIT TESTING");
            ArithmeticOperation operation = new ArithmeticOperation();
            Console.WriteLine("Addition is :"+ operation.Add(10, 20));
            Console.WriteLine("Substraction is :"+ operation.Sub(20, 30));
            Console.WriteLine("Multiplication is :" + operation.Mul(20, 30));
            Console.WriteLine("Division is :"+ operation.Div(20, 10));
        }
    }
}
