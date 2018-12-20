using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFstatements
{
    class MainClass
    {
        static void Main(string[] args)
        {
            // maj note - next task is to filter out 0's and strings
            double num01;
            double num02;

            Console.Write("Put a number ere lad! and I'll divide it: ");
            num01 = Convert.ToDouble(Console.ReadLine());

            Console.Write("put a number ere to be divided by: ");
            num02 = Convert.ToDouble(Console.ReadLine());

            // you want to compare num01 and num02 with 0, if either is 0 than throw error
            if (num01 == 0) // '==' to compare values, || used for or'ing 2 conditions 
            {
                Console.WriteLine("error");
                Console.WriteLine("Can't be devided");
            }
            else
            {
                Console.WriteLine(num01 + " divide by " + num02 + " is equal to " + num01 / num02);


                Console.ReadKey();
                Console.WriteLine(); //Gonna read up on how to loop the application, but this is what i have so far. 
            }

            Console.ReadKey();
        }
    }
}
