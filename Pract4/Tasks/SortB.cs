using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract4
{
    class SortB<T> : ListFilling, ISortable<T>, IDisplayable where T : IComparable<T>
    {
        public List<T> Values = new();

        private int Partrition(List<T> Values, int first, int pivot)
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

        public void Sort(params object[] arguments) 
        {
            List<T> Values = (List<T>)arguments[0];
            int first = (int)arguments[1];
            int pivot = (int)arguments[2];

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
