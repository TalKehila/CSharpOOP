using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace realPlayGround
{
    internal class SortByAge : IComparer<Person>/*,IComparer*/
    {
        public int Compare(Person x, Person y)
        {
            if (x == null || y == null)
                throw new ArgumentNullException();
            return x.Age-y.Age;
        }

        //  another way 
        //public int Compare(object x, object y)
        //{
        //    if (!(x is Person))
        //    {
        //        throw new ArgumentException();
        //    }
        //    if (!(y is Person))
        //    {
        //        throw new ArgumentException();
        //    }
        //}
    }
}
