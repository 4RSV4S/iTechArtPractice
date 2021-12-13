using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;

namespace Pract3
{
    class Employee : User, IDisplayable
    {
        public string CompanyName { get; set; }
        public string CompanyCountry { get; set; }
        public string CompanyCity { get; set; }
        public string CompanyAddress { get; set; }

        public void Display()
        {
            Console.WriteLine($"Hello, I am {FullName}, {JobTitle} in {CompanyName} \n ({CompanyCountry}, {CompanyCity}, {CompanyAddress}) and my salary is  {JobSalary.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-us"))}.\n");
        }
    }
}
