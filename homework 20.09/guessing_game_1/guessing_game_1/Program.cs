using System;

namespace try3
{
    public class guessing_game_1
    {
        public static void Main(string[] args)
        {
            solution_1();
        }
        public static void solution_1()
        {
            Random rand = new Random();
            int number = rand.Next(100);
            Console.WriteLine("Hello! You have to guess the number that I made up.");
            Console.WriteLine("Please enter your answer option from 0 to 100, and I will prompt you.");
            while (true)
            {
                int answer = Convert.ToInt32(Console.ReadLine());
                if (answer == number)
                {
                    Console.WriteLine("Great!");
                    break;
                }
                else
                {
                    if (answer > number) Console.WriteLine("Too Much! Try again.");
                    else if (answer < number) Console.WriteLine("Too Little! Try again.");
                }
            }
        }
    }
}