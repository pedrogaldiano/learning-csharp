/* 
Number Guessing Game, where if the person guess wrong
the computer will tell if you should guess a number higher or lower.

It should be possible to run a computer vs computer game.
*/

using System;
using System.Threading;


namespace Project
{
    enum State
    {
        lower,
        higher,
        right
    }
    class Program
    {   
        static void PrintRange(int min, int max)
        {
            Console.WriteLine($"I'm thinking in a number between {min} and {max}, make a guess!");
        }
        static int InputUser(int min, int max)
        {   
            int input;
            do
            {
                string s = Console.ReadLine();
                if (!int.TryParse(s, out input))
                {
                    Console.WriteLine("Guess an Integer!");
                }
            }
            while (input < min || input > max);

            return input;
        }
        static State CheckInput(int input, int rnd)
        {
            if (input > rnd)
            {
                Console.WriteLine("Guess a lower number!");
                return State.lower;
            }
            else if (input < rnd)
            {
                Console.WriteLine("Guess a higher number!");
                return State.higher;
            }
            else
            {
                Console.WriteLine("YOU GUESSED RIGHT!");
                return State.right;
            }
        }
        static int Computer(int input)
        {
            Console.WriteLine(input);
            return input;
            Thread.Sleep(50);
        }
        static void Main(string[] args)
        {   int min = 0;
            int max = 100;
            Random rnd = new Random();
            int number = (int)rnd.Next(min, max);

            bool key = true;

            while (key)
            {
                PrintRange(min, max);

                // int input = InputUser(min, max); //User plays
                int input = Computer((int)rnd.Next(min, max)); //Computer plays
                State result = CheckInput(input, number);

                // Console.ReadLine();

                switch (result)
                {
                    case State.higher:
                        min = input;
                        break;
                    case State.lower:
                        max = input;
                        break;
                    case State.right:
                        key = false;
                        break;
                }
            }
        }
    }
}
