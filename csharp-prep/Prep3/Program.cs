using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicnumber = randomGenerator.Next(1, 101);
        int guess = -1;
        int guesscount = 0;
        
        while(guess != magicnumber)
        {
            Console.Write("Enter magic number: ");
            guess = int.Parse(Console.ReadLine());
            guesscount++; 

            if(guess == magicnumber)
            {
                Console.Write($"You guessed it in {guesscount} attempts.");
            }
            else if(guess > magicnumber)
            {
                Console.WriteLine("lower");
            }
            else if(guess < magicnumber)
            {
                Console.WriteLine("higher");
            }  
        }


    
       
    
        
        
        
        
        
        
        
        




        
        


        


        
         
    }
}