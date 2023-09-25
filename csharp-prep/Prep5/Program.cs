using System;

class Program
{
    static void Main(string[] args)
    {
        

    // displays a welcome message
    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the program!");
    }


    // asks for and returns users name
    static string PromptUserName(){
        Console.Write("Please input your name: ");
        string name = Console.ReadLine();
        
        return name;
    }


    // asks for and returns favorite number
    static int PromptUserNumber(){
        Console.Write("Please enter your favorite number: ");
        string inputNumber = Console.ReadLine();
        int number = int.Parse(inputNumber);

        return number;
    }


    // squares favorite number
    static int SquareNumber(int Num1){
        int squaredNumber = Num1 * Num1;

        return squaredNumber;
    }


    // displays squared result from last method
    static void DisplayResult(string name, int Num2){
        Console.WriteLine($"{name}, the square of your number is {Num2}.");
    }


    // executing all methods
    DisplayWelcome();
    string userName = PromptUserName();
    int favNum = PromptUserNumber();
    int squaredFavNum = SquareNumber(favNum);
    DisplayResult(userName, squaredFavNum);


    }
}