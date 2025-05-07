using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

namespace IntCollections
{
    public class Program
    {
        private static void Main(string[] args)
        {
            List<int>list = new List<int>();
            Stack<int>stack = new Stack<int>();
            Queue<int>queue = new Queue<int>();
            HashSet<int>hashset = new HashSet<int>();


            int[] inputs = new int[] {1, 10, -30, 10, -5};

            foreach(int number in inputs)
            {
                list.Add(number);
            }

            foreach(int number in inputs)
            {
                stack.Push(number);
            }

            foreach(int number in inputs)
            {
                queue.Enqueue(number);
            }

            foreach(int number in inputs)
            {
                hashset.Add(number);
            }

            Console.WriteLine("List: " + String.Join(", ", list));

            Console.WriteLine("Stack : " + String.Join(", ", stack));

            Console.WriteLine("Queue : " + String.Join(", ", queue));
            
            Console.WriteLine("Hashset : " + String.Join(", ", hashset));
        }
    }
}
