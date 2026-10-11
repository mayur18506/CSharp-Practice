using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Sorted_Dictionary._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int,string> student =new SortedDictionary<int,string>();

            student.Add(4, "Aman");
            student.Add(3, "Mohan");
            student.Add(1, "Sohan");
            student.Add(2, "Rohan");

            foreach (KeyValuePair<int,string> kv in student)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
            Console.WriteLine("Enter the key to search for Names :");
            int i=Convert.ToInt32(Console.ReadLine());

            if (student.ContainsKey(i))
            {
                Console.WriteLine("Student Name Found Is :" + student[i]);
            }
            else
            {
                Console.WriteLine("Student Entry Not Found");
            }

            student.Remove(i);
            Console.WriteLine("After Removing The Entry :");
            foreach (KeyValuePair<int, string> kv in student)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
            Console.ReadLine();
        }
    }
}
