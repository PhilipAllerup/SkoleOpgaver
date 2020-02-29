using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace GuesserOpgave
{
    class Guesser
    {
        const int maxTries = 10;

        static void Main(string[] args)
        {
            

            string chosenName = null;
            int minVal = 1;
            int maxVal = 4;
            int timesGuessed = 0;
            string currentGuess = null;
            string[] names = { "Harry", "Charlie", "James" };


            Console.WriteLine("Welcome, To the Game of Names");
            Console.WriteLine("You have 10 tries to guess my common, english name");

            //Random Name picker 
            Random rnd = new Random();
            int rndnum = rnd.Next(minVal, maxVal);

            switch (rndnum)
            {
                case 1:
                    chosenName = names[0];
                    break;
                case 2:
                    chosenName = names[1];
                    break;
                case 3:
                    chosenName = names[2];
                    break;
            }
            //Console.WriteLine("Spoiler, my name is " + chosenName);

            //if u still got guesses
            while (timesGuessed < maxTries)
            {
                currentGuess = Console.ReadLine();

                //Checks if guess = name, ignores casesensitivity
                if (currentGuess.Equals(chosenName, StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("Congratulations, you've correctly guessed my name");
                    Thread.Sleep(1000);
                    Console.WriteLine("You win absolutely nothing, but the satisfaction of having guessed my name");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("You've guessed incorrectly");
                    timesGuessed++;
                    int triesLeft = maxTries - timesGuessed;
                    if (triesLeft > 0) //no need to be told u got 0 guesses left
                    Console.WriteLine("You have " + triesLeft + " guesses left, try again");
                }
            }
            if (timesGuessed >= maxTries) //too many guesses = lose
            {
                Console.WriteLine("You've failed to guess my name");
                Console.WriteLine("I therefore bid you goodbye");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
    }
}
