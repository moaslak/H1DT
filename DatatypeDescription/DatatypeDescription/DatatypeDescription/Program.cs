using System;

namespace DatatypeDescription;
internal class Program
{

    static void Main(string[] args)
    {
        Console.SetBufferSize(1920, 1080);
        Console.SetWindowSize(1920, 1080);
        
        MemoryBlock mb = new MemoryBlock();
        menu menu = new menu();



        int mode = 0;
        int arraySize = 0;
        while (true)
        {
            mode = menu.Menu();
            arraySize = menu.isArray();
            mb.Draw(mode,arraySize);
            Console.ReadKey();
            Console.Clear();
        }
    }
}