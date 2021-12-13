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
            var factory = new UserFactory();
            factory.CreateRandomAmountOfUsers("Employee");
            reportE.UserSort(factory.employees);
            var cand = new Candidate();
            var reportC = new CandidateReportGenerator();
            Console.WriteLine("\n");
            factory.CreateRandomAmountOfUsers("Candidate");
            reportC.UserSort(factory.candidates);
        }
    }
}
