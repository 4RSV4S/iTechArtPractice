using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;

namespace Pract3
{
    class UserFactory
    {
        public Candidate[] candidates;
        public Employee[] employees;
        public void CreateRandomAmountOfUsers(string who)
        {
            Random rnd = new Random();
            int usersCount = rnd.Next(10, 30);
            if (who == "Candidate")
            {
                candidates = new Candidate[usersCount];
                for (int i = 0; i < candidates.Length; i++)
                {
                    candidates[i] = new Faker<Candidate>("en")
                    .StrictMode(false)
                    .RuleFor(x => x.FirstName, f => f.Name.FirstName())
                    .RuleFor(x => x.LastName, f => f.Name.LastName())
                    .RuleFor(x => x.JobTitle, f => f.Name.JobTitle())
                    .RuleFor(x => x.JobDescription, f => f.Name.JobDescriptor())
                    .RuleFor(x => x.JobSalary, f => f.Random.Decimal(100, 5000));
                    candidates[i].dismissalReason = candidates[i].GetDismissalReason();
                    candidates[i].Display();
                }
            }
            else if (who == "Employee")
            {
                employees = new Employee[usersCount];
                for (int i = 0; i < employees.Length; i++)
                {
                    employees[i] = new Faker<Employee>("en")
                    .StrictMode(false)
                    .RuleFor(x => x.FirstName, f => f.Name.FirstName())
                    .RuleFor(x => x.LastName, f => f.Name.LastName())
                    .RuleFor(x => x.JobTitle, f => f.Name.JobTitle())
                    .RuleFor(x => x.JobDescription, f => f.Name.JobDescriptor())
                    .RuleFor(x => x.JobSalary, f => f.Random.Decimal(100, 5000))
                    .RuleFor(x => x.CompanyName, f => f.Company.CompanyName())
                    .RuleFor(x => x.CompanyCountry, f => f.Address.Country())
                    .RuleFor(x => x.CompanyCity, f => f.Address.City())
                    .RuleFor(x => x.CompanyAddress, f => f.Address.StreetAddress());
                    employees[i].Display();
                }
            }
        }
    }
}
