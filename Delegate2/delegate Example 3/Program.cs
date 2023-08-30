using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace delegate_Example_3
{
    public delegate void  StringDelegate(string str);
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 1 way to do 
            StringDelegate stringDelegate = ToUpperCase;
            stringDelegate("this is lowercase");

            //// way number 2 
            stringDelegate.Invoke("this is another lowercase");

            stringDelegate = ToLowerCase; // HERE WE CHANGE IT BACK TO LOWER CASE 
            stringDelegate.Invoke("THIS NEED TO BE LOWER CASE");

            // case 3 
            WriteOutput("this is a lowercase string", stringDelegate);


        }
        static void ToUpperCase(string str) => Console.WriteLine(str.ToUpper());
        static void ToLowerCase(string str) => Console.WriteLine(str.ToLower());

        // case 3 
        static void WriteOutput (string text,StringDelegate st)
        {
            Console.WriteLine($"Before : {text}");
            st(text);
        }

    }
}
