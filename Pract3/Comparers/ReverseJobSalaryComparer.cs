using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract3 
{
    class ReverseJobSalaryComparer : IComparer<Employee>
    {
        public int Compare(Employee empl1, Employee empl2)
        {
            if (empl1.JobSalary < empl2.JobSalary)
                return 1;
            else if (empl1.JobSalary > empl2.JobSalary)
                return -1;
            else
                return 0;
        }
    }
}
