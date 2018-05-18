using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180228_1._6_Homework_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "_20180228_1._6_Homework_DateTime";

            DateTime myValue = DateTime.Now;
            Console.WriteLine(myValue.ToString());
            Console.WriteLine(myValue.ToShortDateString());
            Console.WriteLine(myValue.ToShortTimeString());
            Console.WriteLine(myValue.ToLongDateString());
            Console.WriteLine(myValue.ToLongTimeString());
            Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            Console.WriteLine(myValue.AddHours(3).ToLongTimeString());
            Console.WriteLine(myValue.AddDays(-3).ToLongDateString());
            Console.WriteLine(myValue.AddHours(-3).ToLongTimeString());

            Console.WriteLine(myValue.Month);

            DateTime myBirthday = new DateTime(1963, 01, 09);

            Console.WriteLine(myBirthday.ToLongDateString());

            DateTime myBirthday2 = DateTime.Parse("1/9/1963");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday2);

            Console.WriteLine(myAge.TotalDays);

            Console.ReadLine();
        }
    }
}
