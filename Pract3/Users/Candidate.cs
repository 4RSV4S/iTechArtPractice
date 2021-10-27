using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using Bogus.DataSets;

namespace Pract3
{
    public class Candidate : UserFactory, IDisplayable
    {
        public string dismissalReason { get; set; }

        enum DismissalReason
        {
            FamilyReasons,
            ProfessionalGrowthLack,
            LowSalary,
            BadTeamMicroclimate,
            LackManagementUnderstanding,
            Other,
            DidntWork
        }

        private string GetDismissalReason()
        {
            var rnd = new Random();
            string DismissalReasonOut;
            DismissalReason rndDismissalReason = (DismissalReason)rnd.Next(Enum.GetNames(typeof(DismissalReason)).Length);
            switch (rndDismissalReason)
            {
                case DismissalReason.FamilyReasons:
                    DismissalReasonOut = "Family reasons";
                    break;
                case DismissalReason.ProfessionalGrowthLack:
                    DismissalReasonOut = "Lack of professional growth";
                    break;
                case DismissalReason.LowSalary:
                    DismissalReasonOut = "Low salary";
                    break;
                case DismissalReason.BadTeamMicroclimate:
                    DismissalReasonOut = "Bad team microclimate";
                    break;
                case DismissalReason.LackManagementUnderstanding:
                    DismissalReasonOut = "Lack of management understanding";
                    break;
                case DismissalReason.Other:
                    DismissalReasonOut = "Other reasons";
                    break;
                case DismissalReason.DidntWork:
                    DismissalReasonOut = null;
                    break;
                default:
                    DismissalReasonOut = null;
                    break;
            }
            return DismissalReasonOut;
        }
        public void Display()
        {
            if (dismissalReason == null)
                Console.WriteLine($"Hello, I am {FullName}.\n I want to be a {JobTitle} ({JobDescription}) with a salary from {JobSalary.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-us"))}.\n I haven't worked anywhere before.\n");
            else
                Console.WriteLine($"Hello, I am {FullName}. \n I want to be a {JobTitle} ({JobDescription}) with a salary from {JobSalary.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-us"))}.\n I quit my previous job for a reason of {dismissalReason}.\n");
        }

        public Candidate[] CreateRandomAmountOfUsers()
        {
            Random rnd = new Random();
            int candidateCount = rnd.Next(10, 30);
            Candidate[] candidates = new Candidate[candidateCount];
            for (int i = 0; i < candidates.Length; i++)
            {
                candidates[i] = new Faker<Candidate>("en")
                    .StrictMode(false)
                    .RuleFor(x => x.FirstName, f => f.Name.FirstName())
                    .RuleFor(x => x.LastName, f => f.Name.LastName())
                    .RuleFor(x => x.JobTitle, f => f.Name.JobTitle())
                    .RuleFor(x => x.JobDescription, f => f.Name.JobDescriptor())
                    .RuleFor(x => x.JobSalary, f => f.Random.Decimal(100, 5000))
                    .RuleFor(x => x.dismissalReason, f => GetDismissalReason());
                candidates[i].Display();
            }
            return candidates;
        }
    }
}
