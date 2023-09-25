using System;

class Program
{
    static void Main(string[] args)
    {
    // Creating a new list
    List<int> numbers = new List<int>();

    Console.WriteLine("Enter a list of numbers, type 0 when finished.");
    
    int userNumber = -1;


    while (userNumber != 0){
        Console.Write("Enter number: ");
        userNumber = int.Parse(Console.ReadLine());

        numbers.Add(userNumber);



    }
    // Add up the sum of the numbers
    int sum = 0;
    foreach (int number in numbers){
        sum += number;
    }
    Console.WriteLine($"The Sum is: {sum}");

        
    // average of numbers
    float average = ((float)sum) / numbers.Count;
    Console.WriteLine($"The avergae is: {average}");

    
    //Largest number Finder
    int largestNumber = numbers[0];
    foreach (int number in numbers){
        if (number > largestNumber){
            largestNumber = number;
        }

    }

    Console.WriteLine($"The largest number: {largestNumber}");

    }
}
