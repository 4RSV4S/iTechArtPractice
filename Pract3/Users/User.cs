using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract3
{
    public abstract class User
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GetFullName
        {
            get
            {
                return FullName = $"{FirstName} {LastName}";
            }
        }
        public string FullName { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public double JobSalary { get; set; }

        public User(string firstName, string lastName, string jobTitle, string jobDescription, double jobSalary)
        {
            Id = Guid.NewGuid().ToString();
            FirstName = firstName;
            LastName = lastName;
            JobTitle = jobTitle;
            JobDescription = jobDescription;
            JobSalary = jobSalary;
        }
        public User() { }
    }
}

