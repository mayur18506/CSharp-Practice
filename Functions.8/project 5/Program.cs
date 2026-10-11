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
            public void m1(int i,int j)
        {
            int result = i+j;
            Console.WriteLine(result);
        }
            public static void Main(string[] args)
            {
                eec1 e1 = new eec1();  //Creating object of class
                e1.m1(10, 16); //Calling the function m1 using the object e1
                Console.ReadLine();
            }
        }
    }
}
