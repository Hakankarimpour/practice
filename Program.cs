using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hakan
{
    internal class Human
    {
        int age;
        static void Main(string[] args)
        {
            Human a = new Human();
            Console.WriteLine(a.userAge());
            Console.WriteLine(a.drink());
            Console.WriteLine(a.food());

        }

        public int userAge()
        {

            Console.WriteLine("Enter your birth year");
            int birthYear = Convert.ToInt32(Console.ReadLine());
            PersianCalendar pc = new PersianCalendar();
            int year = pc.GetYear(DateTime.Now);
            int data = year - birthYear;
            int result = age += data;
            return result;

        }
        public string drink()

        {
            string law = (age >= 18) ? "Drinking is allowed" : "Drinking is not allowed";
            return law;
        }
        public string food()
        {
            return "Eating is allowed";
        }
    }
}
