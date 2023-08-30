using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace realPlayGround
{
    abstract class Person:IBreath,IComparable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name,int age)
        {
            Name = name;
            Age = age;
        }
        public override string ToString() 
        {
            return $"name: {Name}, age: {Age}";
            int x=Name.CompareTo("asaf");//aaron x>0\ziv x<0/asaf x==0
        }

        public virtual void TakeBreath()
        {
            Console.WriteLine($"im human, my name is: {Name} and i took a breath");
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException();
            }
            if (!(obj is Person))
            {
                throw new ArgumentException();
            }
            Person p1 = (Person)obj;
            return Name.Length - p1.Name.Length;
        }
    }
}
