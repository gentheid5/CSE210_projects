using System;

class Program
{
    static void Main(string[] args)
    {
        // random number generator 
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);

        // random number set point outside of magic number range
        int numberGuess = -1;

        // while loop for guessing
        while (numberGuess != magicNumber){

            Console.Write("What is your guess? ");
            numberGuess = int.Parse(Console.ReadLine());

            if (numberGuess < magicNumber){
                Console.WriteLine("Higher");
            }
            else if (numberGuess > magicNumber){
                Console.WriteLine("Lower");
            }
            else{
                Console.WriteLine("Correct!");
            }
        }
    
    }
}