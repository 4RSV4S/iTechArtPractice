using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using Bogus.DataSets;

namespace Pract3
{
    public class Candidate : User, IDisplayable
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

        public string GetDismissalReason()
        {
            var rnd = new Random();
            DismissalReason rndDismissalReason = (DismissalReason)rnd.Next(Enum.GetNames(typeof(DismissalReason)).Length);
            switch (rndDismissalReason)
            {
                case DismissalReason.FamilyReasons:
                    return "Family reasons";
                case DismissalReason.ProfessionalGrowthLack:
                    return "Lack of professional growth";
                case DismissalReason.LowSalary:
                    return "Low salary";
                case DismissalReason.BadTeamMicroclimate:
                    return "Bad team microclimate";
                case DismissalReason.LackManagementUnderstanding:
                    return "Lack of management understanding";
                case DismissalReason.Other:
                    return "Other reasons";
                case DismissalReason.DidntWork:
                    return null;
                default:
                    return null;
            }
        }
        public void Display()
        {
            if (dismissalReason == null)
                Console.WriteLine($"Hello, I am {FullName}.\n I want to be a {JobTitle} ({JobDescription}) with a salary from {JobSalary.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-us"))}.\n I haven't worked anywhere before.\n");
            else
                Console.WriteLine($"Hello, I am {FullName}. \n I want to be a {JobTitle} ({JobDescription}) with a salary from {JobSalary.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-us"))}.\n I quit my previous job for a reason of {dismissalReason}.\n");
        }
    }
}
