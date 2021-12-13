using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;

namespace Pract3
{
    public abstract class User
    {
        public string Id
        {
            get
            {
                return Guid.NewGuid().ToString();
            }
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public decimal JobSalary { get; set; }
    }
}

