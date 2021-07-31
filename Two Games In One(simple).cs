using System;

namespace _2_Game_in_one_simple_
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1) Number Game");
            Console.WriteLine("2) Guessing game");
            Console.WriteLine("3) Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                printNumbers();
                return true;
            }
            else if(result == "2")
            {
                guessingGame();
                return true;
            }
            else if(result == "3")
            {
                return false;
            }
            else
            {

            }
        }
        private static void printNumbers()
        {
            Console.Clear();
            Console.WriteLine("Print numbers");
            Console.Write("Enter a number: ");
            int result = int.Parse(Console.ReadLine());
            int counter = 1;
            while(counter <result +1)
            {
                Console.Write(counter);
                Console.Write("-");
                counter++;
            }
            Console.ReadLine();
        }
        private static void guessingGame()
        {
            Console.Clear();
            Console.WriteLine("Guessing game");
            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 11);
            int guesses = 0;
            bool incorrect = true;
            do
            {
                Console.WriteLine("Enter a number to guess: ");
                string result = Console.ReadLine();
                guesses++;
                if (result == randomNumber.ToString())
                {
                    incorrect = false;
                }
                else
                {
                    Console.Write("Wrong");
                }
            } while (incorrect);
            Console.Write("Correct & it took you {0} guesses",guesses);
            Console.ReadLine();
        }
    }
}
