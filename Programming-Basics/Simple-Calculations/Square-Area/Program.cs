using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = double.Parse(Console.ReadLine());

            var sourceCurrency = Console.ReadLine();
            if (sourceCurrency == "BGN")
            {
                value *= 1.0;
            }
            else if (sourceCurrency == "USD")
            {
                value *= 1.79549;
            }
            else if (sourceCurrency == "EUR")
            {
                value *= 1.95583;
            }
            else if (sourceCurrency == "GBP")
            {
                value *= 2.53405;
            }
            else
            {
                throw new InvalidOperationException("Invalid currency: " + sourceCurrency);
            }

            var destCurrency = Console.ReadLine();
            if (destCurrency == "BGN")
            {
                value /= 1.0;
            }
            else if (destCurrency == "USD")
            {
                value /= 1.79549;
            }
            else if (destCurrency == "EUR")
            {
                value /= 1.95583;
            }
            else if (destCurrency == "GBP")
            {
                value /= 2.53405;
            }
            else
            {
                throw new InvalidOperationException("Invalid currency: " + destCurrency);
            }

            Console.WriteLine(Math.Round(value, 2) + " " + destCurrency);
        }
    }
}
