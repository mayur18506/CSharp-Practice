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
                Console.WriteLine("Method of Base class ");
            }
           
        }


        public class B : A
        {
            public void m1()
            {
                Console.WriteLine("Method of Deried class");
            }
        }
        class C
        {
            public static void Main(string[] args)
            {
                B b1 = new B();
                b1.m1();
              
                Console.ReadLine();
            
            }
        }
    }
}
