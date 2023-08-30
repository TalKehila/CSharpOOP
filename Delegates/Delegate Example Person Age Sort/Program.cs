using System;
using System.Collections.Generic;

namespace Delegate_Example_Person_Age_Sort
{
    internal class Program
    { 
        delegate bool FilterAges(Person p);
        static void Main(string[] args)
        {
            Person p1 = new Person() { Name = "Tal", Age = 25 };
            Person p2 = new Person() { Name = "Avi", Age = 11 };
            Person p3 = new Person() { Name = "Guy", Age = 66 };
            Person p4 = new Person() { Name = "Shani", Age = 31 };
            Person p5 = new Person() { Name = "Baz", Age = 17 };

            List<Person> people = new List<Person>() { p1, p2, p3, p4, p5 };

            Display("Child", people, IsChild);
            Display("Adults", people, IsAdult);
            Display("Seniors", people, IsSenior);



        }
        static void Display(string title, List<Person> people, FilterAges ages)
        {
            Console.WriteLine(title);

            foreach (Person person in people)
            {
                if (ages(person))
                {
                    Console.WriteLine("{0}, {1} years old " ,person.Name , person.Age);
                }
            }

            
        }

        static bool IsChild(Person p)
        {
            return p.Age < 18;
        }

        static bool IsAdult(Person p)
        {
            return p.Age >= 18;
        }
        static bool IsSenior(Person p)
        {
            return p.Age >= 66;
        }
    }
}
