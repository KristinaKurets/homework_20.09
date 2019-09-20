using System;

namespace try5
{
    public class guessing_game_2
    {
        public static void Main(string[] args)
        {
            solution_2();
        }
        public static void solution_2()
        {
            bool flag = true;
            int answer = 64;
            int step = 32;
            int counter = 0;
            Console.WriteLine("Hello, stranger. It's time to test my mental abilities.");
            Console.WriteLine("Think of a number from 0 to 100. I'll try to guess the number in 7 attempts.");
            Console.WriteLine("You just have to tell me your number is less or more than mine, ok? And if I'll guess it, tell me I'm right. Let's start!");
            while (flag && counter != 7)
            {
                counter++;
                Console.WriteLine($"I think it's {answer} ");
                string reaction = Console.ReadLine().ToLower();
                if (counter == 7)
                {
                    Console.WriteLine("Sorry, no more attemps. Good Bye!");
                    break;
                }
                if (reaction == "less")
                {
                    step = step / 2;
                    answer = answer - step; ;
                }
                else
                {
                    if (reaction == "more")
                    {
                        step = step / 2;
                        answer = answer + step; ;
                    }
                    else
                    if (reaction == "right")
                    {
                        Console.WriteLine("Yeah! I did it!");
                        flag = false;
                    }
                    else
                        Console.WriteLine("Sorry, I don't understand you. Please, write my number is less, more than yours or I'm right.");
                }
            }
        }
    }
}