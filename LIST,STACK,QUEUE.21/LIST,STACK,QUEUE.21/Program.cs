using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIST_STACK_QUEUE._21
{
    internal class eec1
    {
        static void Main(string[] args)
        {
            //var student = new List<string>();  //List is created that can store string elements
            //student.Add("Aman");
            //student.Add("Mohan");
            //student.Add("Sohan");
            //student.Add("Rohan");
            //student.Add("Mohan");

            //foreach (var item in student)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadLine();    //1


            //Stack<int> i = new Stack<int>();
            //i.Push(1);
            //i.Push(2);
            //i.Push(3);
            //i.Push(4);

            //foreach (var item in i)
            //{
            //    Console.WriteLine(item);
            //}

            //i.Pop();
            //Console.WriteLine("After pop of one element");
            //foreach (var item in i)
            //{
            //    Console.WriteLine(item);     //2
            //}

            Queue<int> i = new Queue<int>();
            i.Enqueue(1);
            i.Enqueue(2);
            i.Enqueue(3);
            i.Enqueue(4);

            foreach (var item in i)
            {
                Console.WriteLine(item);
            }

            i.Dequeue();
            Console.WriteLine("After pop of one element");
            foreach (var item in i)
            {
                Console.WriteLine(item);     //2
            }
        }

    }
}
