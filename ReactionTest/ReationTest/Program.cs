using System;
using System.Diagnostics;
using System.Threading;
namespace listClassFromScratch
{
    class Program
    {

        static void Main()
        {
            char mode = '1';
            bool run = true;

            Stopwatch sw = new Stopwatch();
            Random rand = new Random();
            while (run)
            {
                if (mode == '1')
                {
                    Console.WriteLine("Reaction Test");
                    Console.WriteLine();
                    Console.WriteLine("Press ENTER to start");
                    Console.ReadLine();
                    
                    Console.WriteLine("3");
                    Thread.Sleep(rand.Next(200, 1500));
                    Console.WriteLine("2");
                    Thread.Sleep(rand.Next(100, 700));
                    Console.WriteLine("1");
                    Thread.Sleep(rand.Next(50, 600));
                    Console.WriteLine("GO!");
                    sw.Start();
                    Console.WriteLine("PRESS SPACE BAR TO GET REACTION TIME!!!");
                    while (Console.ReadKey().Key != ConsoleKey.Spacebar)
                    {

                    }
                    sw.Stop();

                    Console.WriteLine("You used: " + sw.ElapsedMilliseconds.ToString() + " ms");
                    Console.WriteLine("Press 1 to restart");
                    Console.WriteLine("Press anything else to stop the application");
                    do
                    {
                        
                    }while(!(Char.TryParse(Console.ReadLine(), out mode)));
                    
                }
                else
                    Environment.Exit(0);
                        
            }
        }
    }
}