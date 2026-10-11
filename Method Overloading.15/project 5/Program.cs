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
            public void m1(int i)
            {
                Console.WriteLine(i + " : Method with integer argument ");
            }
            public void m1(float f)
            {
                Console.WriteLine(f + " : Method with float argument ");
            }
        }

      
        public class B
        {
       
        public static void Main(string[] args)
            {
                A a=new A();
                a.m1(4);
                a.m1(5.5f);
                Console.ReadLine();
            }
        }
    }
}
