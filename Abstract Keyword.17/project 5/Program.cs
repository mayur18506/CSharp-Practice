using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_5
{
    internal class Program
    {
        public abstract class A
        {
            public abstract void m1();
            public void m2()
            {
                Console.WriteLine("M2");
            }
           
        }


         class B : A
        {
            public override void m1()
            {
                Console.WriteLine("M1");
            }
        }
        class C
        {
            public static void Main(string[] args)
            {
                B b1 = new B();
                b1.m1();
                b1.m2();
                Console.ReadLine();
            
            }
        }
    }
}
