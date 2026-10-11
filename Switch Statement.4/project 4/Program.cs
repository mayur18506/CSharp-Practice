using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ente The First Number :");
            int i=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ente The Second Number :");
            int j = Convert.ToInt32(Console.ReadLine());

            int result = 0;

            Console.WriteLine("Ente The Operation to Perform +,-,*,/ ");
            char op = Convert.ToChar(Console.ReadLine());

            switch (op)
            {
                case '+' : result = i + j;
                    break;

                case '-':
                    result = i - j;
                    break;

                case '*':
                    result = i * j;
                    break;

                case '/':
                    result = i / j;
                    break;

                    default: Console.WriteLine("Wrong Input ");
                    break;
            }
            Console.WriteLine("Result Is :" + result);
            Console.WriteLine();
            

        }
    }
}
