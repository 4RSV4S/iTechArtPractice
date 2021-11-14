using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract4
{
    class CyclicList
    {
        public List<Person> Circle = new List<Person>();

        public void RandomListFilling()
        {
            Random rnd = new Random();
            int personCount = rnd.Next(2, 10);

            Console.WriteLine($"The circle consists of {personCount} persons. They are:");
            for (int i = 0; i < personCount; i++)
            {
                Circle.Add(new Person());
                var name = new Bogus.DataSets.Name("en");
                Circle[i].Number = i + 1;
                Circle[i].Name = name.FirstName();
                Console.Write($"[{Circle[i].Number}]{Circle[i].Name} ");
            }
        }
        public void Count()
        {
            int current = 0;
            while (Circle.Count > 1)
            {
                current++;
                if (current >= Circle.Count) current = 0; //If we have reached the end of the list, we return to the beginning
                Circle.RemoveAt(current);
                if (current >= Circle.Count) current = 0; //If we have deleted an item from the end of the list, we return to the beginning
            }
            Console.WriteLine($"\nPerson number [{Circle[0].Number}]{Circle[0].Name} remained.");
        }
    }
}
