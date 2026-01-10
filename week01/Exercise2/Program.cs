using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage for CSE231? ");
        string response = Console.ReadLine();
        int number = int.Parse(response);

        string grade = "";

        if (number >= 90)
        {
            grade = "A";
        }
        else if (number >= 80)
        {
            grade = "B";
        }
        else if (number >= 70)
        {
            grade = "C";
        }
        else if (number >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine($"Your grade for CSE231 is: {grade}");
        
        if (number >= 70)
        {
            Console.WriteLine("Congratulations, you passed CSE231");
        }
        else
        {
            Console.WriteLine("Uh oh, try harder next time!");
        }
    }
}