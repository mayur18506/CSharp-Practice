using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_5
{
    internal class Program
    {
      public  static void Main(string[] args)
        {
        l1:
            Console.WriteLine("Number is less than 10");
            Console.WriteLine("Enter the number : ");
            int i =Convert.ToInt32(Console.ReadLine());
            if (i<10)
            {
                goto l1;
            }
            else
            {
                Console.WriteLine("Number is Greter than 10");

            }
            Console.ReadLine();
        }
    }
}
