using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract3
{
    class EmployeeReportGenerator : Employee, IReportGenerator<Employee>
    {
        public void UserSort(Employee[] array)
        {
            var len = array.Length;
            Array.Sort(array, new CompanyNameComparer());

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("EMPLOYEES SORTED BY COMPANY NAME INCREASING:");
            Console.WriteLine("**************************************************************************************************************\n");
            
            for (var i = 0; i < len; i++)
            {
                Console.WriteLine($"{array[i].Id} | {array[i].CompanyName,-35} | {array[i].FullName,-20} | {array[i].JobSalary.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-us"))}");
            }

            Array.Sort(array, new ReverseJobSalaryComparer());
            
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
