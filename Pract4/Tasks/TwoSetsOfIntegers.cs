using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract4
{
    public class TwoSetsOfIntegers
    {
        public int[] theFirstSet { get; set; }
        public int[] theSecondSet { get; set; }

        public int[] Intersection(int[] a, int[] b)
        {
            var c = a.Intersect(b).ToArray();
            return c;
        }

        public void Display(string s, int[] set)
        {
            Console.WriteLine(s);
            foreach(int i in set)
            {
                Console.Write(i + " ");
            }
        }
    }
}
