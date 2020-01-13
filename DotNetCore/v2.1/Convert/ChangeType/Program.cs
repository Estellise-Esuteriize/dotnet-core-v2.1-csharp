using System;

namespace DotNetCore.v2._1.Convert.ChangeType
{
    public static class Program
    {
        public static void Main()
        {
            A a = new A();
            B b = new B();
            
            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());

            var ba = (A) System.Convert.ChangeType(b, typeof(A));
            
            Console.WriteLine(ba.Message());

        }
    }
}