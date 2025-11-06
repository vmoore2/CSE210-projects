using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What percentage do you have in the class?");
        string userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);
        string letter = "A";

        if (percentage >= 90)
        {
            letter = "A";

        }
        else if (percentage >= 80)
        {
            letter = "B";

        }
        else if (percentage >= 70)
        {
            letter = "C";

        }
        else if (percentage >= 60)
        {
            letter = "D";

        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"You have a {letter} in the class!");
        
        if (percentage >= 70)
        {
            Console.WriteLine("You passed the class!");
        }
        else
        {
            Console.WriteLine("You did not pass this class, but I bet you will next time!");

        }
    }
}