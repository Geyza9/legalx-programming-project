using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace legalxproject
{
    //First child class of Employee
    public class SeniorLawyer : Employee
    {
        public SeniorLawyer(int id, string fullname, DateTime DOB, DateTime joineddate, string otherexpertise, int yearsexperience, string specialisation) : base(id, fullname, joineddate, otherexpertise)
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
            StringBuilder seniorlawyerstats = new StringBuilder();
            seniorlawyerstats.AppendLine(base.ToString());
            seniorlawyerstats.AppendLine($"Date of Birth is; {DateofBirth.ToString("ddMMyyyy")}");
            seniorlawyerstats.AppendLine($"Years Experience are: {YearsExperience}");
            seniorlawyerstats.AppendLine($"Specialisation is: {Specialisation}");

            return seniorlawyerstats.ToString();
        }
    }
}
