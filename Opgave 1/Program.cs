using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write first number");int 
            Int;Int=int.Parse(Console.ReadLine(
            ));Console.WriteLine("Write second value");int Int_=0;int _int;int int_
            =Int_;_int=int.Parse(Console.ReadLine());if (Int!=_int){int_= 
            Int+_int;}else if(Int==_int){int _Int=Int+_int;int_=_Int
            *3;}Console.WriteLine("Result is "+int_);Console.
            WriteLine("Press enter to exit");Console.ReadLine();

            
            
            
            //Spoiler Alert for code

            /*
            int valA;           //Int
            int valB;           //_int 
            int valSum = 0;     //int_ -> Int_

            Console.WriteLine("Write first number");

            valA = int.Parse(Console.ReadLine());

            Console.WriteLine("Write second value");

            valB = int.Parse(Console.ReadLine());

            if (valA != valB)
                valSum = valA + valB;
            else if (valA == valB)
            {
                int tempSum = valA + valB;      //tempSum -> _Int
                valSum = tempSum * 3;
            }
            Console.WriteLine("Result is " + valSum);
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();*/
        }
    }
}
