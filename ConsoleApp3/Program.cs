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
            string Start = "";
            double num01;
            double num02;

            Console.Write("Enter a number to be devided: ");
            num01 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a number to divide by: ");
            num02 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num01 + " divide by " + num02 + " is equal to " + num01 / num02);

            Console.ReadKey();
            Console.WriteLine(); //Gonna read up on how to loop the application, but this is what i have so far. 
          
           
        }
    }
}
