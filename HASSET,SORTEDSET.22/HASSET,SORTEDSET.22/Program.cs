using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HASSET_SORTEDSET._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var student=new HashSet<string>();
            //student.Add("Aman");
            //student.Add("Mohan");
            //student.Add("Sohan");
            //student.Add("Rohan");
            //student.Add("Aman");    //Dublicate value

            //foreach (var item in student)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("Enter Student Name to Delete :");
            //string s= Console.ReadLine();
            //student.Remove(s);
            //Console.WriteLine("After Deletion");

            //foreach (var item in student)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadLine();                  //1


            var student = new SortedSet<string>();
            student.Add("Aman");
            student.Add("Mohan");
            student.Add("Sohan");
            student.Add("Rohan");
            student.Add("Aman");    //Dublicate value

            foreach (var item in student)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Enter Student Name to Delete :");
            string s = Console.ReadLine();
            student.Remove(s);
            Console.WriteLine("After Deletion");

            foreach (var item in student)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
