using System;
using System.Text;
using Bogus;

namespace Pract3
{
    class Program
    {
        static void Main(string[] args)
        {
            var empl = new Employee();
            var reportE = new EmployeeReportGenerator();
            reportE.UserSort(empl.CreateRandomAmountOfUsers());
            var cand = new Candidate();
            var reportC = new CandidateReportGenerator();
            Console.WriteLine("\n");
            reportC.UserSort(cand.CreateRandomAmountOfUsers());
            

        }
    }
}
