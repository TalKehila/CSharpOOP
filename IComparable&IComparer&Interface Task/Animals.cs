using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace realPlayGround
{
    internal class Animals:IBreath
    {
        public string Kind { get; set; }
        public int Paws { get; set; }
        public Animals(string kind,int paws)
        {
            Kind = kind;
            Paws = paws;
        }
        public void TakeBreath()
        {
            if (Kind=="dog")
            {
                Console.WriteLine("bark bark");
            }
            else
            {
                Console.WriteLine("meow");
            }
        }
    }
}
