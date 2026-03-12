using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    int age = 25;
            //    string name = "Vino";
            //    Console.WriteLine("Name:"+ name);
            //    Console.WriteLine("Age:"+age);

            //Even or Odd Program Object creation
            //EvenOddProgram EO=new EvenOddProgram();
            //EO.CheckEvenorOdd();

            //Celsius to Fahrenheit and Vise versa
            CelciusToFranheit CF=new CelciusToFranheit();
            CF.CelciusFranheit();
        }
    }
}
