using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract3
{
    class CandidateReportGenerator : Candidate, IReportGenerator<Candidate>
    {
        public void UserSort(Candidate[] array) //Bubble Sort by JobTitle increasing and then by JobSalary increasing
        {
            var len = array.Length;

            Array.Sort(array, new JobTitleComparer());
            
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("CANDIDATES SORTED BY POSITION:");
            Console.WriteLine("**************************************************************************************************************\n");
            for (var i = 0; i < len; i++)
            {
                Console.WriteLine($"{array[i].Id} | {array[i].JobTitle,-35} | {array[i].FullName,-20} | {array[i].JobSalary.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-us"))}");
            }

            Array.Sort(array, new JobSalaryComparer());

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
