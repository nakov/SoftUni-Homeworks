using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Celsius = ");
            var cel = double.Parse(Console.ReadLine());
            var fah = cel * 1.8 + 32;
            Console.Write("Fahrenheit = ");
            Console.WriteLine(fah);
        }
    }
}
