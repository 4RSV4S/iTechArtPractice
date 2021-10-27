using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract3
{
    class EmployeeReportGenerator : Employee, IReportGenerator
    {
        private static void Swap(ref Employee e1, ref Employee e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }
        private static bool NeedToReOrder(string s1, string s2)
        {
            for (int i = 0; i < (s1.Length > s2.Length ? s2.Length : s1.Length); i++)
            {
                if (s1.ToCharArray()[i] < s2.ToCharArray()[i]) return false;
                if (s1.ToCharArray()[i] > s2.ToCharArray()[i]) return true;
            }
            return false;
        }

        public void UserSort(Employee[] array) //Bubble Sort by CompanyName increasing and then by JobSalary decreasing
        {
            var len = array.Length;

            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len - 1; j++)
                {
                    if (NeedToReOrder(array[j].CompanyName, array[j + 1].CompanyName))
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("EMPLOYEES SORTED BY COMPANY NAME INCREASING:");
            Console.WriteLine("**************************************************************************************************************\n");
            
            for (var i = 0; i < len; i++)
            {
                Console.WriteLine($"{array[i].Id} | {array[i].CompanyName,-35} | {array[i].FullName,-20} | {array[i].JobSalary.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-us"))}");
            }

            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (array[j].JobSalary < array[j + 1].JobSalary)
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }

            Console.WriteLine("\n**************************************************************************************************************");
            Console.WriteLine("EMPLOYEES SORTED BY SALARY DECREASING:");
            Console.WriteLine("**************************************************************************************************************\n");
            for (var i = 0; i < len; i++)
            {
                Console.WriteLine($"{array[i].Id} | {array[i].CompanyName,-35} | {array[i].FullName,-20} | {array[i].JobSalary.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-us"))}");
            }
        }
    }
} 
