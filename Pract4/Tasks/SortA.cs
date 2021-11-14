using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract4
{
    class SortA<T> : ISortable<T>, IDisplayable
    {
        public List<T> Values = new List<T>();

        public void RandomListFilling(List<int> Values)
        {
            Random rnd = new Random();
            int listSize = rnd.Next(5, 15);
            Console.WriteLine("A source list of integers:");
            for (int i = 0; i < listSize; i++)
            {
                Values.Add(rnd.Next(0, 99));
                Console.Write($"{Values[i]} ");
            }
        }
        public void RandomListFilling(List<string> Values)
        {
            Random rnd = new Random();
            int listSize = rnd.Next(5, 15);
            Console.WriteLine("\nA source list of strings:");
            for (int i = 0; i < listSize; i++)
            {
                var str = new Bogus.DataSets.Lorem("en");
                Values.Add(str.Word());
                Console.Write($"{Values[i]} ");
            }
        }
        public void Sort<T>(List<T> Values) where T : IComparable<T>
        {
            int lenJ;
            int lenJAddOne;
            for (var i = 1; i < Values.Count; i++)
            {
                for (var j = 0; j < Values.Count - i; j++)
                {
                    if (Values is List<string>) // Partrition of elements of both int and string types is provided inside a single method
                    {
                        lenJ = Values[j].ToString().Length; // There we have to apply method ToString() to string (lol) because of using the universal type T
                        lenJAddOne = Values[j + 1].ToString().Length;
                        if (lenJ.CompareTo(lenJAddOne) <= 0)
                        {
                            T temp = Values[j];
                            Values[j] = Values[j + 1];
                            Values[j + 1] = temp;
                        }
                    }
                    else if (Values is List<int>)
                    {
                        if (Values[j].CompareTo(Values[j + 1]) <= 0)
                        {
                            T temp = Values[j];
                            Values[j] = Values[j + 1];
                            Values[j + 1] = temp;
                        }
                    }
                }
            }
        }
        public void Display()
        {
            if (Values is List<int>)
            {
                Console.WriteLine("\nA sorted list of integers:");
            }
            else if (Values is List<string>)
            {
                Console.WriteLine("\nA sorted list of strings:");
            }
            for (int i = 0; i < Values.Count; i++)
            {
                Console.Write($"{Values[i]} ");
            }
        }


    }
}
