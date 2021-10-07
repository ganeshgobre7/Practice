using System;
using System.Collections.Generic;
using System.Text;
using NLog;

namespace UnitTestingPractice
{
   public class ArithmeticOperation
    {
        public Logger logger = LogManager.GetCurrentClassLogger();
        public int Add(int num1,int num2)
        {            
            logger.Info("Addition Success");
            return num1 + num1; 
        }

        public int Sub(int num1, int num2)
        {
            logger.Info("Substraction Success");
            return num1 - num2;                      
        }

        public int Mul(int num1, int num2)
        {
            logger.Info("Multiplication Success");
            return num1 * num2;          
        }

        public int Div(int num1, int num2)
        {
            logger.Info("Division Success");
            return num1 / num2;
           
        }
    }
}
