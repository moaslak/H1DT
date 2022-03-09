using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatatypeDescription
{
    internal class menu
    {
        int mode = 0;
        int size = 0;
        int arraySize = 0;
        bool inputOk = false;
        public int Menu()
        {
            bool inputOk = false;
            Console.WriteLine("Welcome text");
            Console.WriteLine();

            Console.WriteLine("1 - int16");
            Console.WriteLine("2 - float");
            Console.WriteLine("3 - double");
            Console.WriteLine("4 - byte");
            Console.WriteLine("5 - bool");
            Console.WriteLine("6 - char");
            Console.WriteLine("0 - EXIT APP");

            
            while(!inputOk)
            {
                do
                {
                    Console.Write("datatype select: ");
                } while (!(Int32.TryParse(Console.ReadLine(), out mode)));
                Console.WriteLine();
                switch (mode)
                {
                    case 1:
                        size = sizeof(Int16);
                        Console.WriteLine("int16 selected");
                        Console.Write("Posible combinations: " + (Math.Pow((double)2, (double)(size * 8))).ToString("N0")+"\n");
                        inputOk = true;
                        break;
                    case 2:
                        size = sizeof(float);
                        Console.WriteLine("float selected");
                        Console.Write("Posible combinations: " + Math.Pow((double)2, (double)(size * 8)).ToString("N0") + "\n");
                        inputOk = true;
                        break;
                    case 3:
                        size = sizeof(double);
                        Console.WriteLine("double selected");
                        Console.Write("Posible combinations: " + Math.Pow((double)2, (double)(size * 8)).ToString("N0") + "\n");
                        inputOk = true;
                        break;
                    case 4:
                        size = sizeof(byte);
                        Console.WriteLine("byte selected");
                        Console.Write("Posible combinations: " + Math.Pow((double)2, (double)(size * 8)).ToString("N0") + "\n");
                        inputOk = true;
                        break;
                    case 5:
                        size = sizeof(bool);
                        Console.WriteLine("bool selected");
                        Console.Write("Posible combinations: 2" + "\n");
                        inputOk = true;
                        break;
                    case 6:
                        size = sizeof(char);
                        Console.WriteLine("char selected");
                        Console.Write("Posible combinations: " + Math.Pow((double)2, (double)(size * 8)).ToString("N0") + "\n");
                        inputOk = true;
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Pick a valid datatype");
                        mode = 1337;
                        break;
                }
            }
            return size;
        }

        public int isArray()
        {
            do
            {
                do
                {
                    Console.Write("Enter array size, must be minimum 1 and maximum 8: ");
                } while (!(Int32.TryParse(Console.ReadLine(), out arraySize)));
            }while(arraySize < 1 || arraySize > 8);
            
            Console.WriteLine();
            return arraySize;
        }
    }
}
