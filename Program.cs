using System.ComponentModel.Design;

Console.WriteLine("Enter two values to perform operations on them");
Console.WriteLine("Select an operation: ");
Menu();

Console.ReadKey();

    static void Menu ()
{
    Console.Clear();

    Console.WriteLine("1 - Sum");
    Console.WriteLine("2 - Subtract");
    Console.WriteLine("3 - Multiply");
    Console.WriteLine("4 - Division");
    Console.WriteLine("5 - Exit");

    Console.WriteLine("-------------------");
    Console.WriteLine("Select an option: ");

try
{
    short result = short.Parse(Console.ReadLine());
     switch (result){

        case 1: Sum (); break;
        case 2: Subtract (); break;
        case 3: Multi (); break;
        case 4: Division (); break;
        case 5: System.Environment.Exit(0); break;
        default: Menu(); break;
     }
}
catch
{
    Console.WriteLine("Please enter only numbers!");
    Console.ReadKey();
    Menu();
}

}

    static void Sum ()
    {
        Console.Clear();

        Console.WriteLine("First value:");
        float value1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Second value");
        float value2 = float.Parse(Console.ReadLine());

        float result = value1 + value2;
        Console.WriteLine($"The result is: {result}");

        Console.ReadKey();
        Menu();
        
    }

    static void Subtract ()
    {
        Console.Clear();

        Console.WriteLine("First value:");
        float value1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Second value");
        float value2 = float.Parse(Console.ReadLine());

        float result = value1 - value2;
        Console.WriteLine($"The result is: {result}");

        Console.ReadKey();
        Menu();
        
    }

    static void Multi ()
    {
        Console.Clear();

        Console.WriteLine("First value:");
        float value1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Second value");
        float value2 = float.Parse(Console.ReadLine());

        float result = value1 * value2;
        Console.WriteLine($"The result is: {result}");

        Console.ReadKey();
        Menu(); 
    }

    static void Division ()
    {
        Console.Clear();

        Console.WriteLine("First value:");
        float value1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Second value");
        float value2 = float.Parse(Console.ReadLine());

        float result = value1 / value2;
        Console.WriteLine($"The result is: {result}");

        Console.ReadKey();
        Menu();
        
    }