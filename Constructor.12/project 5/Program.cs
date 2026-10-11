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
            eec1(){
                Console.WriteLine("Default");
            }
           ~eec1()
            {
                Console.WriteLine("Destructor");
                Console.ReadLine();

            }

            public static void Main(string[] args)
            {
                eec1 e1 = new eec1();
               
                Console.ReadLine();
            }
        }
    }
}
