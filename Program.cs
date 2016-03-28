using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> myList = new LinkedList<int>();
            myList.AddFirst(4);
            myList.AddFirst(3);
            myList.AddFirst(2);
            myList.AddFirst(1);
            myList.AddLast(5);
            myList.AddLast(6);
            myList.AddLast(7);
            myList.AddLast(8);
            myList.Print();
            Console.WriteLine("-------------");
            //myList.RemoveFirst();
            //myList.RemoveFirst();
            //myList.RemoveLast();
            //myList.RemoveLast();
            //if (myList.Find(52))
            //{
            //    Console.WriteLine(52);
            //}
            //else
            //{ Console.WriteLine("no"); }
            myList.Remove(1);
            myList.Remove(8);
            //myList.Remove(2);
            //myList.Remove(2);
            //myList.Remove(4);
            myList.Print();
            //if (myList.Find(2))
            //{
            //    Console.WriteLine("Found");
            //}
            //myList.Print();
            Console.ReadKey();

        }
    }
}
