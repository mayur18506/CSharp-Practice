using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_5
{
    internal class Program
    {
        public class A
        {
            public void m1()
            {
                Console.WriteLine("Method of class A ");
            }
        }

        public class B:A
        {
            public void m2()
            {
                Console.WriteLine("Method of class B ");
            }
        }

        public class C:B
        {
            public void m3()
            {
                Console.WriteLine("Method of class C ");
            }
        }

        public class D
        {
       
        public static void Main(string[] args)
            {
                C c1=new C();
                c1.m1();
                c1.m2();
                c1.m3();

                Console.ReadLine();
            }
        }
    }
}
