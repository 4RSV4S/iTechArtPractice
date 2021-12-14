using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract4
{
    public class ListFilling
    {
        public List<int> RandomListFilling(List<int> Values)
        {
            Random rnd = new Random();
            int listSize = rnd.Next(5, 15);
            Console.WriteLine("A source list of integers:");
            for (int i = 0; i < listSize; i++)
            {
                Values.Add(rnd.Next(0, 99));
                Console.Write($"{Values[i]} ");
            }
            return Values;
        }
        public List<string> RandomListFilling(List<string> Values)
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
            return Values;
        }
    }
}
