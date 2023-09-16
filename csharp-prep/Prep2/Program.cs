using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please input your grade percentage. ");
        string inputPercentage = Console.ReadLine();
        int percentage = int.Parse(inputPercentage);

        //variable for grade
        string grade;

        // grade percentage if statement chain
        if (percentage > 89)
        {
            grade = "A";
        }

        else if (percentage > 79)
        {
            grade = "B";
        }
        else if (percentage > 69)
        {
            grade = "C";
        }
        else if (percentage > 59)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine($"Your grade is: {grade}.");

        if (percentage > 69)
        {
            Console.WriteLine("Congrats, you passed!");
        }
        else
        {
            Console.WriteLine("You didn't pass, but don't give up!");
        }

    }
}