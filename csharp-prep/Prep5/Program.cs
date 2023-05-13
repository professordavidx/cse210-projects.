using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayName();
        string userName = PromptUserName();
        int favoritenum = PromptUserNumber();
        
    }

    static void DisplayName()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string response = Console.ReadLine();
        return response;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        int favoritenumber = int.Parse(Console.ReadLine());
        return favoritenumber;
    }

    static int squared(int number)
    {
        int result = number * number;
        return result;
    }

}

