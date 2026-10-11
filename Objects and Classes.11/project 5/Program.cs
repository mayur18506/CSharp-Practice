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
            int id;
            string name;
            public void add(int i, string s)
            {
                id = i;
                name=s;
            }
            public void show()
            {
                Console.WriteLine("Id is :" + id + "Student Name is :" + name);
            }
        }
      public  static void Main(string[] args)
        {
            eec1 s1 = new eec1();
            eec1 s2 = new eec1();
            s1.add(1, "Mayur");
            s2.add(2, "Aman");
            s1.show();
            s2.show();

            Console.ReadLine();
        }
    }
}
