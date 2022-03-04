using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitCalculator
{
    /// <summary>
    /// Takes strings from Console.ReadLine(), and converts these to different numberic datatypes.
    /// </summary>
    internal class InputHandler
    {
        /// <summary>
        /// Reads a line input and converts it to a double.
        /// </summary>
        /// <remarks>When calling the function, it will loop until it receives an input that can be parsed to a double.
        /// The function print the input argument to the console.
        /// </remarks>
        /// <param name="prompt"></param>
        /// <returns>double</returns>
        public double getDouble(string prompt)
        {
            double number = 0;
            do
            {
                Console.Write(prompt);
                Console.WriteLine();
            } while (!(double.TryParse(Console.ReadLine(), out number)));
            return number;
        }

        /// <summary>
        /// Reads a line input and converts it to a int.
        /// </summary>
        /// <remarks>When calling the function, it will loop until it receives an input that can be parsed to a int.
        /// The function print the input argument to the console.
        /// </remarks>
        /// <param name="prompt"></param>
        /// <returns>int</returns>
        public int getInt(string prompt)
        {
            int number = 0;
            do
            {
                Console.Write(prompt);
                Console.WriteLine();
            } while (!(Int32.TryParse(Console.ReadLine(), out number)));
            return number;
        }
    }
}
