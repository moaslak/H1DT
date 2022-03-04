using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitCalculator
{
    /// <summary>
    /// A simple calculator that can do the four main aririthimic functions for to doubles.
    /// </summary>
    internal class Calc
    {
        /// <summary>
        /// Addition function, a+b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>double</returns>
        public double plus(double a, double b)
        {
            double result = a + b;
            Console.WriteLine("Result of addition is: " + result);
            return result;
        }

        /// <summary>
        /// subtraction function, a-b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>double</returns>
        public double minus(double a, double b)
        {
            double result = a - b;
            Console.WriteLine("Result of subtraction is: " + result);
            return result;
        }

        /// <summary>
        /// Multiplication function, a*b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>double</returns>
        public double multiply(double a, double b)
        {
            double result = a * b;
            Console.WriteLine("Result of multiplication is: " + result);
            return result;
        }
        /// <summary>
        /// Divide function, a/b.
        /// </summary>
        /// <remarks>
        /// Inputing b=0, will return 0
        /// </remarks>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>double</returns>
        public double div(double a, double b)
        {
            double result = 0;
            if (b == 0)
            {
                Console.Write("CANNOT DIVIDE BY ZERO");
                return result;
            }
            else
            {
                result = a / b;
                Console.WriteLine("Result of division is: " + result);
                return result;
            }
        }
    }
}