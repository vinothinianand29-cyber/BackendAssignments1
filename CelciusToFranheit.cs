using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConApp
{
    internal class CelciusToFranheit
    {
        public void CelciusFranheit()
        {
            //Celcius to Franheit----> F formula(F= (celsius * 9 / 5) + 32)

            Console.Write("Enter temperature in Celcius: ");
            
            double celcius=Convert.ToDouble(Console.ReadLine());

            double fahrenheit = (celcius * 9 / 5) + 32;

            Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);

            //Franheit to  Celsius----> C formula(c = (f - 32) * 5 / 9)

            Console.Write("Enter temperature in Fahrenheit: ");

            double fah = Convert.ToDouble(Console.ReadLine());

            double cel =(fah - 32) * 5 / 9;

            Console.WriteLine("Temperature in Celcius: " + cel);







        }
    }
}
