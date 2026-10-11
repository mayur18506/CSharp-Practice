using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_5
{
    internal class Program
    {
        public class eec1
        { 
        public void m1(ref int val)
        {
            val = val + 10;
            Console.WriteLine("Value in the called function is :" + val);
        }
            public static void Main(string[] args)
            {
                int val = 15;
                eec1 e1 = new eec1();
                Console.WriteLine("Value before calling the Function :" + val);
                e1.m1(ref val);
                Console.WriteLine("Value after calling the function :" + val);
                Console.ReadLine();
            }
        }
    }
}
