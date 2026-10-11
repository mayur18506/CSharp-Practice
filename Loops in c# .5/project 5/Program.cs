using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 2; i <= 20; i=i+2)
            //{
            //    Console.WriteLine(i);
            //    Console.ReadLine();
            //}


            //Console.WriteLine("i   j");
            //for (int i = 1; i <= 3; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        Console.WriteLine(i + "   " + j);
            //    }
            //}
            //Console.ReadLine();


            //int i = 1;
            //while (i<20)
            //{
            //    Console.WriteLine(i);
            //    i = i + 2;
            //}
            //Console.ReadLine();


            //int i = 1;
            //while (i <=2)
            //{
            //    int j = 1;
            //    while (j<=3)
            //    {
            //        Console.WriteLine(i + "   " + j);
            //        j++;
            //    }
            //    i++;
            //}
            //Console.ReadLine();


            int i = 2;
            do
            {
                Console.WriteLine(i);
                i = i + 2;
            }
            while (i<=20);
            Console.ReadLine();
        }
    }
}
