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


        //int age;
       
        static void Main(string[] args)
        {
            Human a = new Human();
            //Console.WriteLine(a.userAge());
            //Console.WriteLine(a.drink());
            //Console.WriteLine(a.food());

            Console.WriteLine(a.Compar());

        
            

}

        //public int userAge()
        //{

        //    Console.WriteLine("Enter your birth year");
        //    int birthYear = Convert.ToInt32(Console.ReadLine());
        //    PersianCalendar pc = new PersianCalendar();
        //    int year = pc.GetYear(DateTime.Now);
        //    int data = year - birthYear;
        //    int result = age += data;
        //    return result;

        //}
        //public string drink()

        //{
        //    string law = (age >= 18) ? "Drinking is allowed" : "Drinking is not allowed";
        //    return law;
        //}
        //public string food()
        //{
        //    return "Eating is allowed";
        //}
        public string Compar()
        {

            char[] arr1 = { 'a', 'f', 'b', 'c', 'd', 'e', 'g', 'h', 'i', 'j' };
            char[] arr2 = { 'j', 'i', 'h', 'b', 'g', 'f', 'e', 'd', 'c', 'a' };
           
            Array.Sort(arr1);
            Array.Sort(arr2);
            string result = "";
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    result = "No";
                    break;
                }
                else { result = "Yes"; }
               
            }
         return result;   

        }



    }
}

