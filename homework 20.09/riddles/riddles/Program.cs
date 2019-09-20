using System;

namespace try4
{
    public class Riddles
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, stranger. I want to play a game with you. Try to guess all my riddles. You have only 3 attempts.");
            RiddlesGame();
        }

        public static void RiddlesGame()
        {
            string FirstRiddle = "I will sacrifice a soft thread around, and after I'll hug and poison. Enter your answer, please...";
            Riddle(FirstRiddle, "spider", 3);

            string SecondRiddle = "Who does't breathe, but lives; although it’s not necessary, he drinks a lot; both in life and in death, the body is like ice. Enter your answer, please...";
            Riddle(SecondRiddle, "fish", 3);

            string ThirdRiddle = "Without rest, without sleep, with a soundless step from hill to hill, who moves slowly, who came to drive away the cold ? Enter your answer, please...";
            Riddle(ThirdRiddle, "sun", 3);

            Console.WriteLine("Congratulations! All riddles solved!");
        }

       public  static void Riddle(string RiddleText, string RightAnswer, int attemps)
        {
            Console.WriteLine("Here is the riddle:");
            string answer = "";
            string isRight = "You are right, right answer is";
            while (answer != RightAnswer)
            {
                if (attemps == 0)
                {
                    isRight = "Right answer was";
                    break;
                }
                Console.WriteLine($"{RiddleText}");
                answer = Console.ReadLine();
                if (answer != RightAnswer) 
                {
                    attemps--;
                    Console.WriteLine($"Wrong! You have {attemps} attempts left.");
                }
            }
            Console.WriteLine($"{isRight} {RightAnswer}");
        }
    }
}