﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LambdaStarter
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> people = new List<Person>();
            people.Add(new Person() {Name = "Yossi", Age = 20});
            people.Add(new Person() { Name = "Assaf", Age = 30 });
            people.Add(new Person() { Name = "Zoe", Age = 17 });
            people.Add(new Person() { Name = "Dan", Age = 70 });

            Console.WriteLine("Original list");
            Console.WriteLine("--------------");
            printList(people);

            // using FindAll find all people whose Age is greater or equal to 20
            List<Person> subList = ????????????????
            Console.WriteLine("People with Age greater or equal to 20: ");
            Console.WriteLine("--------------");
            printList(subList);

           
            // try : Find all people with Name != Yossi
            List<Person> subList2 = ???????????????????????
            Console.WriteLine("People with Name != Yossi: ");
            Console.WriteLine("---------------------------");
            printList(subList2);

           
            // try: Sort all people by Name using Sort method with comparison delegate
            
            people.Sort(????????????????????????);
            Console.WriteLine("People List Sorted By Name ");
            Console.WriteLine("---------------------------");
            printList(people);


            // try: Find the max Age of all people,  use Max
            
            int a = people.Max(??????????????????);
            Console.WriteLine("Person with Max Age");
            Console.WriteLine("--------------------");
            Console.WriteLine("The age of the oldest person is: " + a);

            // try 

            Person firstOdd = people.First(???????????????????????????????);
            Console.WriteLine("first person with Age Whose odd number is: " + firstOdd);

        }
        public static void printList(List<Person> list)
        {
            foreach (Person p in list)
                Console.WriteLine(p);
        }
    }

    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return "Name: " + Name + " Age: " + Age;
        }
    }
}
// exmaple for find age
//foreach (var p in people)
//{
//    //if (true)
//    //if (p.Age > 20)
//    if (Validation(p))
//    {
//        subList.Add(p);
//    }
//}

//people.FindAll(p => true);
//people.FindAll(p => p.Age > 20);
//people.FindAll(p => Validation(p));