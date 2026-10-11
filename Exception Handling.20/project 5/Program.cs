using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_5
{
    internal class Program
    {
        public class notvalidage : Exception
        {
            public notvalidage(string s) : base(s)
            {

            }
        }
        class eec1
        {
            static void checkage(int i)
            {
                if (i<18)
                {
                    throw new notvalidage("Age is not valid");
                }
            }
        
        public static void Main(string[] args)
        {
           
            try
            {
                    checkage(16);
            }
            catch (notvalidage m)
            {

                Console.WriteLine(m);
               
            }
           
            Console.ReadLine();
            }
        }
    }
}
