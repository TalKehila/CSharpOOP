using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace InterfaceAnimals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBreath b = new Dog();
            //b.TakeBreath();
            IBreath c = new Cat();
            //c.TakeBreath();
            Dog dog = new Dog();
            //dog.TakeBreath();
              int v= b.Mul(5, 4);
            Console.WriteLine(v);

            Console.WriteLine("the 2  list");

            List<int> dognumber = dog.Something();
            Console.WriteLine("dogs numbers");
            foreach(int i in dognumber)
            {
                Console.WriteLine(i);
            }

            List<int> catnumbers = c.Something();
            Console.WriteLine("cats numbers");
            foreach (int i in catnumbers)
            {
                Console.WriteLine(i);
            }


        }
    }
    interface IBreath
    {
        void TakeBreath();

        int Mul (int x,int y );

        List<int> Something();
    }
    public class Dog : IBreath
    {
        public void TakeBreath() => Console.WriteLine("Woff Woff");

        public int Mul(int x, int y) => 3*x * y;

        public List<int> Something()
        {
            List<int> result = new List<int>();
            result.Add(3);
            return result;
        }
    }
    public class Cat : IBreath
    {
        public void TakeBreath() => Console.WriteLine("Mew Mew");

        public int Mul(int x , int y ) => 5 * x + y;

        public List<int> Something()
        {
            List<int> number = new List<int>();       
            number.Add(6);
            return number;
        }

    }


}
