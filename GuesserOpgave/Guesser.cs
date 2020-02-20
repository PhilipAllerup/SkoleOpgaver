using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuesserOpgave
{
    class Guesser
    {
        const int MaxTrials = 10;

        static void Main(string[] args)
        {

            string chosenName;

            Console.WriteLine("Welcome, To the Game of Names");
            Console.WriteLine("You will now be given 10 tries to guess a random name from some world");

            string[] names = { "name1", "Name2", "Name3", "Name4", "Name5"};

            Random rnd = new Random();
            int rndnum = rnd.Next(1, 6);

            switch (rndnum)
            {
                case 1:
                    //something
                    break;
            }

            Console.ReadLine();
            
            
        }

        
    }
}
