using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_builder
{ 
   
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("hello world");
            for (int i = 0; i < 5; i++)
            {
                sb.Append("nice to meet you");
            }
            //sb.Clear(); // clear all 
            string s = sb.ToString();
            Console.WriteLine(s);



            sb.AppendLine("hello world"); // appendLine its like \n 
            sb.AppendLine("hello world");
            Console.WriteLine(sb.ToString());

           // using remove
          StringBuilder sb1 = new StringBuilder("hello world");
            sb1.Remove(0, 2);
            Console.WriteLine(sb1.ToString());


            StringBuilder sb2 = new StringBuilder("hello i am new here");
            sb2.Replace("h", "_");
            Console.WriteLine(sb2.ToString());
            Console.WriteLine(sb2.Length.ToString());



        }


    }
}
