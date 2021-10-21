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

        public Employee(string firstName, string lastName, string jobTitle, string jobDescription, double jobSalary, string companyName, string companyCountry, string companyCity, string companyAddress) : base(firstName, lastName, jobTitle, jobDescription, jobSalary)
        {
            CompanyName = companyName;
            CompanyCountry = companyCountry;
            CompanyCity = companyCity;
            CompanyAddress = companyAddress;
        }
        public Employee() { }
        public void Display()
        {
            Console.WriteLine($"Hello, I am {GetFullName}, {JobTitle} in {CompanyName} \n ({CompanyCountry}, {CompanyCity}, {CompanyAddress}) and my salary is  {JobSalary:C2}.\n");
        }
        public void AddRandomAmountOfEmployee()
        {
            Random rnd = new Random();
            int employeeCount = rnd.Next(2, 10);
            Employee[] employees = new Employee[employeeCount];
            for (int i = 0; i < employeeCount; i++)
            {
                employees[i] = new Faker<Employee>("en")
                    .StrictMode(false)
                    .RuleFor(x => x.FirstName, f => f.Name.FirstName())
                    .RuleFor(x => x.LastName, f => f.Name.LastName())
                    .RuleFor(x => x.JobTitle, f => f.Name.JobTitle())
                    .RuleFor(x => x.JobDescription, f => f.Name.JobDescriptor())
                    .RuleFor(x => x.JobSalary, f => f.Random.Double(100, 5000))
                    .RuleFor(x => x.CompanyName, f => f.Company.CompanyName())
                    .RuleFor(x => x.CompanyCountry, f => f.Address.Country())
                    .RuleFor(x => x.CompanyCity, f => f.Address.City())
                    .RuleFor(x => x.CompanyAddress, f => f.Address.StreetAddress());
                employees[i].Display();
            }
        }
    }

}
