using System;
using try4;
using try3;
using try5;

namespace quiz
{
    class Program
    {
       static void Main(string[] args)
       {
            int answer;
            Console.WriteLine("Hello Stranger! I think, you want to play a game. So I have 3 to choose from.");
            Console.WriteLine("If you want to guess riddles from Sphynx, enter '1'.");
            Console.WriteLine("If you want to guess the number I think, enter '2'.");
            Console.WriteLine("If you want to test my guessing abilities, enter '3'.");

            answer = Convert.ToInt32(Console.ReadLine());
            var form1 = new try4.Riddles();
            var form2 = new try3.guessing_game_1();
            var form3 = new try5.guessing_game_2();
            if (answer == 1)
                Riddles.RiddlesGame();
            if (answer == 2)
                guessing_game_1.solution_1();
            if (answer == 3)
                guessing_game_2.solution_2();
        }
    }
}

