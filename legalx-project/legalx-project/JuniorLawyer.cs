using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace legalxproject
{
    //Second Child class of employee
    public class JuniorLawyer : Employee
    {
        public JuniorLawyer(int id, string fullname, DateTime DOB, DateTime joineddate, string otherexpertise, int yearsexperience, string specialisation) : base(id, fullname, joineddate, otherexpertise)
        {
            YearsExperience = yearsexperience;
            Specialisation = specialisation;
            DateofBirth = DOB;
        }
        public int YearsExperience { get; set; }
        public string Specialisation { get; set; }
        public DateTime DateofBirth { get; set; }

        public override string ToString()
        {
            StringBuilder juniorlawyerstats = new StringBuilder();
            juniorlawyerstats.AppendLine(base.ToString());
            juniorlawyerstats.AppendLine($"Date of Birth is; {DateofBirth.ToString("ddMMyyyy")}");
            juniorlawyerstats.AppendLine($"Years Experience are: {YearsExperience}");
            juniorlawyerstats.AppendLine($"Specialisation is: {Specialisation}");

            return juniorlawyerstats.ToString();
        }
    }
}
