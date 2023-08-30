using System;

namespace ConsoleDisposable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (A a = new A())
            {

            }
        }
    }

    class A : IDisposable
    {
        B b = new B();
        D d = new D();
        public void Dispose()
        {
            b.Dispose();
            d.Dispose();
            Console.WriteLine("Disp A");
        }
    }

    class B : IDisposable
    {
        C c = new C();
        public void Dispose()
        {
            c.Dispose();
            Console.WriteLine("Disp B");
        }
    }

    class C : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Disp C");
        }
    }

    class D : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Disp D");
        }
    }
}
