using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                Console.WriteLine("Enter the Marks :");
                int i = Convert.ToInt32(Console.ReadLine());
                if (i >=75)
                {
                    Console.WriteLine("A Grade");
                   
                }
            else if(i>60 && i<75)
            {
                Console.WriteLine("B Grade");
            }
            else
            {
                Console.WriteLine("C Grade");
            }
            Console.ReadLine();
        }
        }

    }
