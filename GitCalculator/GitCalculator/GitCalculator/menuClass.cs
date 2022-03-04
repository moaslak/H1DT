namespace GitCalculator;

public class menuClass
{
    double Tal1;
    double Tal2;
    int operation = 0;
    Calc calc = new Calc();
    InputHandler inputHandler = new InputHandler();
    
    /// <summary>
    /// Prints the menu and calls InputHandler and Calc.
    /// Called by main and is looped indefinitly. Programmes closes when '5' is input into the menu.
    /// </summary>
    public menuClass()
    {
        Console.WriteLine("GitCalculator");
        Console.WriteLine("1 - Addition");
        Console.WriteLine("2 - Subtraction");
        Console.WriteLine("3 - Multiplication");
        Console.WriteLine("4 - Division");
        Console.WriteLine("5 - Close app");
        Console.WriteLine();

        Console.WriteLine("Input an integer between 1 - 5");
        operation = inputHandler.getInt("Select mode: ");

        if (operation > 0 || operation < 6)
        {
            Console.WriteLine();
            switch (operation)
            {
                case 1:
                    Console.WriteLine("Addition");
                    Tal1 = inputHandler.getDouble("Input the first number: ");
                    Tal2 = inputHandler.getDouble("Input the second number: ");
                    calc.plus(Tal1, Tal2);
                    Console.Write("Press a key to reset...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 2:
                    Console.WriteLine("Subtraction");
                    Tal1 = inputHandler.getDouble("Input the first number: ");
                    Tal2 = inputHandler.getDouble("Input the second number: ");
                    calc.minus(Tal1, Tal2);
                    Console.Write("Press a key to reset...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 3:
                    Console.WriteLine("Multiplication");
                    Tal1 = inputHandler.getDouble("Input the first number: ");
                    Tal2 = inputHandler.getDouble("Input the second number: ");
                    calc.multiply(Tal1, Tal2);
                    Console.Write("Press a key to reset...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 4:
                    Tal1 = inputHandler.getDouble("Input the first number: ");
                    Tal2 = inputHandler.getDouble("Input the second number: ");
                    calc.div(Tal1, Tal2);
                    Console.Write("Press a key to reset...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 5:
                    Console.WriteLine("App closing");
                    System.Threading.Thread.Sleep(1000);
                    System.Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Choose 1, 2, 3, 4 or 5");
                    Console.Write("Press a key to reset...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }
        else
        {
            Console.WriteLine("Choose 1, 2, 3, 4 or 5");
            Console.Write("Press a key to reset...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}