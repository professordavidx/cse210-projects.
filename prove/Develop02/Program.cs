using System;

class Program
{
    static void Main(string[] args)
    {
        ShowMenu();
    }

    public static void ShowMenu()
    {
        Console.WriteLine("Welcome to the Journal program!");
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do? ");
    }


}

