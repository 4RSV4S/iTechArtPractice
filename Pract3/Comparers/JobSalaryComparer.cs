using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract3
{
    class JobSalaryComparer : IComparer<Candidate>
    {
        public int Compare(Candidate cand1, Candidate cand2)
        {
            if (cand1.JobSalary > cand2.JobSalary)
                return 1;
            else if (cand1.JobSalary < cand2.JobSalary)
                return -1;
            else
                return 0;
        }
    }
}
