using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract3
{
    class CandidateReportGenerator : Candidate, IReportGenerator
    {
        private static void Swap(ref Candidate c1, ref Candidate c2)
        {
            var temp = c1;
            c1 = c2;
            c2 = temp;
        }
        public bool NeedToReOrder(string s1, string s2)
        {
            for (int i = 0; i < (s1.Length > s2.Length ? s2.Length : s1.Length); i++)
            {
                if (s1.ToCharArray()[i] < s2.ToCharArray()[i]) return false;
                if (s1.ToCharArray()[i] > s2.ToCharArray()[i]) return true;
            }
            return false;
        }
        public void UserSort(Candidate[] array) //Bubble Sort by JobTitle increasing and then by JobSalary increasing
        {
            var len = array.Length;

            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len - 1; j++)
                {
                    if (NeedToReOrder(array[j].JobTitle, array[j + 1].JobTitle))
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("CANDIDATES SORTED BY POSITION:");
            Console.WriteLine("**************************************************************************************************************\n");
            for (var i = 0; i < len; i++)
            {
                Console.WriteLine($"{array[i].Id} | {array[i].JobTitle,-35} | {array[i].FullName,-20} | {array[i].JobSalary.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-us"))}");
            }

            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (array[j].JobSalary > array[j + 1].JobSalary)
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }

            Console.WriteLine("\n**************************************************************************************************************");
            Console.WriteLine("CANDIDATES SORTED BY SALARY INCREASING:");
            Console.WriteLine("**************************************************************************************************************\n");
            for (var i = 0; i < len; i++)
            {
                Console.WriteLine($"{array[i].Id} | {array[i].JobTitle,-35} | {array[i].FullName,-20} | {array[i].JobSalary.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-us"))}");
            }
        }
    }
}
