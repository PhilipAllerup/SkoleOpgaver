using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Peergrade_3_Data_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            //make stack
            Stack<int> numStack = new Stack<int>();

            //info
            Console.WriteLine("yo, so I'm gonna need a couple of numbers, one at a time please");
            Thread.Sleep(1000);

            //put numbers onto stack
            Console.WriteLine("First number");
            numStack.Push(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Cheers, second number");
            numStack.Push(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("And lastly, third number");
            numStack.Push(Convert.ToInt32(Console.ReadLine()));

            //give back to the people in reverse order
            Console.WriteLine("Thanks for the numbers, you can have them back now");
            foreach( int num in numStack)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("press enter to end me :)");
            Console.ReadLine();

        }
    }
}
