using System;
using System.Linq;
using System.Collections.Generic;

namespace Pract4
{
    class Program 
    {
        static void Main(string[] args)
        {
            TwoSetsOfIntegers sets = new TwoSetsOfIntegers();
            sets.theFirstSet = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            sets.theSecondSet = new[] { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14};
            sets.Display("1-е множество целых чисел:", sets.theFirstSet);
            sets.Display("\n2-е множество целых чисел:", sets.theSecondSet);
            sets.Display("\nНовое множество (пересечение):", sets.Intersection(sets.theFirstSet, sets.theSecondSet));

            MyQueue q = new MyQueue();
            q.queue.Enqueue(3);
            q.queue.Enqueue(2);
            q.queue.Enqueue(19);
            q.queue.Enqueue(4);
            q.queue.Enqueue(7);
            q.queue.Enqueue(5);
            q.queue.Enqueue(8);
            q.queue.Enqueue(12);

            //Console.WriteLine(q.TheSumBetweenMaxAndMin(q.queue));

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(3);
            queue.Enqueue(2);
            queue.Enqueue(19);
            queue.Enqueue(4);
            queue.Enqueue(7);
            queue.Enqueue(5);
            queue.Enqueue(8);
            queue.Enqueue(12);
            int sum = 0;
            while (queue.Count > 0)
            {
                if (i != queue.Max())
                {
                    queue.Dequeue();
                }
                else { break; }
                //queue.Dequeue();

            }
            foreach (int i in queue)
            {
                sum += i;
                if (i == queue.Min())
                {
                    break;
                }
            }
            Console.WriteLine(sum);

        }
    }
}
