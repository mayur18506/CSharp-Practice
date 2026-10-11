using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_5
{
    internal class Program
    {
        public interface  A
        {
            void m1();
           
        }

        public interface A1
        {
            void m1();
        }
         class B : A, A1
        {
            public  void m1()
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
                
                Console.ReadLine();
            
            }
        }
    }
}
