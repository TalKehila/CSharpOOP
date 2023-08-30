using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace realPlayGround
{
    internal class Teacher : Person
    {
        public Teacher(string name, int age) : base(name, age)
        {

        }
        public override string ToString()
        {
            return base.ToString() + " and im a teacher";
        }
        public override void TakeBreath()
        {
            Console.WriteLine($"im a teacher, my name is: {Name} and i took a breath");
        }
    }
}
