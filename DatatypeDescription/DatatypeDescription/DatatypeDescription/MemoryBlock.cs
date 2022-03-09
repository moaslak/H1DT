using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatatypeDescription
{
    internal class MemoryBlock
    {
        public void Draw(int byteBlocks, int arraySize)   
        {
            string topBottom = "+----------+";
            string midSection = "";
            int pad = 15;
            bool addressFlag = true;
            
            for (int i = 0; i < byteBlocks; i++)
            {
               
                midSection = "|  Byte " + (i + 1) + "  |";
                if (addressFlag)
                {
                    for (int j = 0; j < arraySize; j++)
                    {
                        Console.CursorLeft = pad * j;
                        unsafe
                        {
                            int* address = &j;
                            Console.Write($"{(long)address:X}");
                        }
                    }
                }
                addressFlag = false;
                Console.CursorLeft = 0;
                Console.CursorTop = Console.CursorTop + 1;

                for (int j = 0; j < arraySize; j++)
                {
                    Console.CursorLeft = pad * j;
                    Console.Write(topBottom);
                }
                Console.CursorLeft = 0;
                Console.CursorTop = Console.CursorTop+1;
                for (int j = 0; j < arraySize; j++)
                {
                    Console.CursorLeft = pad * j;
                    Console.Write(midSection);
                }
                Console.CursorLeft = 0;
                Console.CursorTop = Console.CursorTop + 1;
                for (int j = 0; j < arraySize; j++)
                {
                    Console.CursorLeft = pad * j;
                    Console.Write(topBottom);
                }
            }
            Console.WriteLine("\n");
            
        }

    }
}
