using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_expmale
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3 };
            double[] doubleArray = { 1.0, 2.0, 3.0 };
            string[] stringArray = { "1", "2", "3" };

            Printarray(intArray);
            Printarray(doubleArray);
            Printarray(stringArray);

        }
        //public static void Printarray(int[] array)
        //{
        //    foreach (int item in array)
        //    {
        //        Console.Write(item + " ");
        //    }
        //}
        //public static void Printarray(double[] array)
        //{
        //    foreach (double item in array)
        //    {
        //        Console.Write(item + " ");
        //    }
        //    //Console.WriteLine();
        //}
        //public static void Printarray(String[] array)
        //{
        //    foreach (String item in array)
        //    {
        //        Console.Write(item + " ");
        //    }

        //}
        public static void Printarray<Thing>(Thing[] array)
        {
            foreach (Thing item in array)
            {
                Console.Write(item + " ");
            }

        }

    }
}
