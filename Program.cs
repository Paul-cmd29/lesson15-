using System;
using System.Collections.Generic;
using System.Linq;

namespace lesson15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Stack<int> number = new Stack<int>();
            number.Push(5);
            number.Push(10);
            number.Push(15);
            number.Push(20);
            number.Push(25);

            int[] arr = new int[4];
            number.CopyTo(ref arr);
            foreach(int nums in arr)
            {
                Console.WriteLine(nums);
            }
            Console.WriteLine(number.Pop());
            Console.WriteLine(number.Peek());

        }
    }
    class Stack<M>
    {
        List<M> list = new List<M>();
        public int Count => list.Count;

        public void Push(M number)
        {
            list.Insert(0, number);
        }

        public M Pop()
        {
            M lst = list.Last();
            list.RemoveAt(list.Count - 1);
            return lst;
        }

        public void Clear()
        {
            list.Clear();
        }

        public M Peek()
        {
            return list.Last();
        }

        public void CopyTo(ref M[] arr)
        {
            arr = list.ToArray();
        }
    }
}
//checked
