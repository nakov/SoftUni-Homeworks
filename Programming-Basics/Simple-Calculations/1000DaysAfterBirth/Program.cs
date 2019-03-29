using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter birthday: ");
            var birthday = DateTime.ParseExact(Console.ReadLine(),
                "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var dateAfter1000Days = birthday.AddDays(999);
            //Console.Write("After one thousand days: ");
            Console.WriteLine(dateAfter1000Days.ToString("dd-MM-yyyy"));
        }
    }
}
