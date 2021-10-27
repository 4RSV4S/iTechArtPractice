using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;

namespace Pract3
{
    class Employee : UserFactory, IDisplayable
    {
        public string CompanyName { get; set; }
        public string CompanyCountry { get; set; }
        public string CompanyCity { get; set; }
        public string CompanyAddress { get; set; }

        public void Display()
        {
            Console.WriteLine($"Hello, I am {FullName}, {JobTitle} in {CompanyName} \n ({CompanyCountry}, {CompanyCity}, {CompanyAddress}) and my salary is  {JobSalary.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-us"))}.\n");
        }
        public Employee[] CreateRandomAmountOfUsers()
        {
            Random rnd = new Random();
            int employeeCount = rnd.Next(10, 30);
            Employee[] employees = new Employee[employeeCount];
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i] = new Faker<Employee>("en")
                    .StrictMode(false)
                    .RuleFor(x => x.FirstName, f => f.Name.FirstName())
                    .RuleFor(x => x.LastName, f => f.Name.LastName())
                    .RuleFor(x => x.JobTitle, f => f.Name.JobTitle())
                    .RuleFor(x => x.JobDescription, f => f.Name.JobDescriptor())
                    .RuleFor(x => x.JobSalary, f => f.Random.Decimal(100m, 5000m))
                    .RuleFor(x => x.CompanyName, f => f.Company.CompanyName())
                    .RuleFor(x => x.CompanyCountry, f => f.Address.Country())
                    .RuleFor(x => x.CompanyCity, f => f.Address.City())
                    .RuleFor(x => x.CompanyAddress, f => f.Address.StreetAddress());
                employees[i].Display();
            }
            return employees;
        }
    }
}
