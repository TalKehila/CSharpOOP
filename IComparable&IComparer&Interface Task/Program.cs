using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace realPlayGround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[5];
            people[0] = new Teacher("asaf", 21);
            people[1] = new Student("yakov", 12);
            people[2] = new Teacher("dumbeldore", 73);
            people[3] = new Teacher("osher", 35);
            people[4] = new Student("michal", 503);
            Animals[] animals = new Animals[2];
            animals[0] = new Animals("dog", 4);
            animals[1] = new Animals("cat", 4);
            EveryoneBreath(people);
            Console.WriteLine("now animals");
            EveryoneBreath(animals);

            Console.WriteLine("before sorting");
            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
            Array.Sort(people);
            Console.WriteLine("after sorting");
            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }

            Array.Sort(people, new SortByAge());
            Console.WriteLine("after sorting by age");
            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
        }
        public static void EveryoneBreath(IBreath[] c1)
        {
            foreach (IBreath tempIBreath in c1)
            {
                tempIBreath.TakeBreath();
            }
        }
    }
}
