using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        WelcomeMessage();
        string userName = PromptUserName();
        int number = PromptUserNumber();
        int squaredNumber = SquareNumber(number);
        DisplayResult(userName, squaredNumber);

          static void WelcomeMessage()
          {
              Console.WriteLine("Welcome to the Program!");
          }

         static string PromptUserName()
         {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
             
            return userName;
         }

         static int PromptUserNumber()
         {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            
            return number;
         }

            static int SquareNumber(int number)
            {
                int square = number * number;
                return square;
            }

            static void DisplayResult(string userName, int squaredNumber)
            {
                Console.WriteLine($"{userName}! the square of your number is {squaredNumber}.");
            }
    }
    
}