using System;
using System.Linq;
using System.Collections.Generic;

namespace Pract4
{
    class Program 
    {

        static void Main(string[] args)
        {
            Console.WriteLine("*********************");
            Console.WriteLine("TASK 1 (SETS)");
            Console.WriteLine("*********************");
            TwoSetsOfIntegers sets = new TwoSetsOfIntegers();
            sets.theFirstSet = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            sets.theSecondSet = new[] { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14};
            sets.Display("1st set of integers:", sets.theFirstSet);
            sets.Display("\n2nd set of integers:", sets.theSecondSet);
            sets.Display("\nNew set (intersection):", sets.Intersection(sets.theFirstSet, sets.theSecondSet));

            Console.WriteLine("\n*********************");
            Console.WriteLine("TASK 2 (QUEUE)");
            Console.WriteLine("*********************");
            MyQueue q = new MyQueue();
            q.RandomQueueFilling();
            q.TheSumBetweenMaxAndMin();

            Console.WriteLine("*********************");
            Console.WriteLine("TASK 3 (CYCLIC LIST)");
            Console.WriteLine("*********************");
            CyclicList cyclicList = new CyclicList();
            cyclicList.RandomListFilling();
            cyclicList.Count();

            Console.WriteLine("*********************");
            Console.WriteLine("TASK 4A (BOUBLE SORT)");
            Console.WriteLine("*********************");

            SortA<int> a = new SortA<int>();
            a.Values = a.RandomListFilling(a.Values);
            a.Sort(a.Values);
            a.Display();

            SortA<string> b = new();
            b.Values = b.RandomListFilling(b.Values);
            b.Sort(b.Values);
            b.Display();

            Console.WriteLine("\n*********************");
            Console.WriteLine("TASK 4B (QUICK SORT)");
            Console.WriteLine("*********************");
            SortB<int> c = new SortB<int>();
            c.Values = c.RandomListFilling(c.Values);
            c.Sort(c.Values, 0, c.Values.Count - 1);
            c.Display();

            SortB<string> d = new();
            d.Values = d.RandomListFilling(d.Values);
            d.Sort(d.Values, 0, d.Values.Count - 1);
            d.Display();
        }
    }
}
