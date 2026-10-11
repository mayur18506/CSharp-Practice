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
            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        if (j == 3)
            //            break;
            //        Console.WriteLine(i + "  " + j);
            //    }

            //}
            //Console.WriteLine("After the loop");
            //Console.ReadLine();                      //1

            for (int i = 1; i <= 4; i++)
            {

                for (int j = 1; j <= 4; j++)
                {
                    if (i == 2 && j == 2)
                    {
                        continue;
                    }
                    Console.WriteLine(i + "  " + j);
                }

            }
            Console.WriteLine("After the loop");
            Console.ReadLine();                        //2

            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 4)
            //        continue;
            //    Console.WriteLine(i);
            //}                                            //3
        }
    }
}
