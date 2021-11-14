using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract4
{
    class SortB<T> : ISortable<T>, IDisplayable
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
                var str = new Bogus.DataSets.Hacker("en");
                Values.Add(str.Noun());
                Console.Write($"{Values[i]} ");
            }
        }
        private int Partrition<T>(List<T> Values, int first, int pivot) where T : IComparable<T>
        {
            int i = first;
            int lenJ;
            int lenPivot;

            for (int j = first; j <= pivot; j++)        
            {
                if (Values is List<string>)
                {
                    lenJ = Values[j].ToString().Length;
                    lenPivot = Values[pivot].ToString().Length;
                    if (lenJ.CompareTo(lenPivot) >= 0)
                    {
                        T temp = Values[i];
                        Values[i] = Values[j];
                        Values[j] = temp;
                        i++;
                    }
                }
                else if (Values is List<int>)
                {
                    if (Values[j].CompareTo(Values[pivot]) >= 0)
                    {
                        T temp = Values[i];
                        Values[i] = Values[j];
                        Values[j] = temp;
                        i++;
                    }
                }
            }
            return i - 1;                       
        }

        public void Sort<T>(List<T> Values, int first, int pivot) where T : IComparable<T>
        {
            if (first >= pivot)
            {
                return;
            }
            int p = Partrition(Values, first, pivot);
            Sort(Values, first, p - 1);
            Sort(Values, p + 1, pivot);
        }

        public void Display()
        {
            if (Values is List<int>)
            {
                Console.WriteLine("\nA sorted list of integers:");
            }
            else if(Values is List<string>)
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
