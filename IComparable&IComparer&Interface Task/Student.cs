using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace realPlayGround
{
    internal class Student:Person
    {
        public Student(string name,int age):base(name,age)
        {
            
        }
        public override string ToString()
        {
            return base.ToString()+" and im a student";
        }
        public override void TakeBreath()
        {
            Console.WriteLine($"im Student, my name is: {Name} and i took a breath");
        }
    }
}
