using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // ShowMenu();
        PromptGenerator test = new PromptGenerator();
        string prompt = test.SelectPrompt();

        Console.WriteLine(prompt);

        Entry entry1 = new Entry();
        entry1._prompt = prompt;

        DateTime theCurrentTime = DateTime.Now;
        entry1._dateTime = theCurrentTime;

        string userAnswer = "this is a mess";
        entry1._answer = userAnswer;


    }

    // public static void ShowMenu()
    // {
    //     Console.WriteLine("Welcome to the Journal program!");
    //     Console.WriteLine("Please select one of the following choices:");
    //     Console.WriteLine("1. Write");
    //     Console.WriteLine("2. Display");
    //     Console.WriteLine("4. Save");
    //     Console.WriteLine("5. Quit");
    //     Console.WriteLine("What would you like to do? ");
    // }

    
    


}

