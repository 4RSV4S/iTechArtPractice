using System;
using Bogus;

namespace Pract3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var empl = new Employee();
            //user.Display();
            empl.AddRandomAmountOfEmployee();
            var cand = new Candidate();
            cand.AddRandomAmountOfCandidate();
            

        }
    }
}
