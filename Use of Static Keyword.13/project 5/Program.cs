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
            static int count = 0;
            void add()
            {
                count++;
                Console.WriteLine("Total Student :" + count);
            }

            public static void Main(string[] args)
            {
                eec1 s1 = new eec1();
                eec1 s2 = new eec1();
                s1.add();
                s2.add();

                Console.ReadLine();
            }
        }
    }
}
