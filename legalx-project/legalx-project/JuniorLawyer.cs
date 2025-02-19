﻿using System;
using System.Text;

namespace legalxproject
{
    //Second Child class of employee
    public class JuniorLawyer : Employee
    {
        public JuniorLawyer() // Default empty constructor
        {

        }

        public JuniorLawyer(int id, string fullname, DateTime DOB, DateTime joineddate, string otherexpertise, int yearsexperience, ESpecialisation specialisation) : base(id, fullname, joineddate, otherexpertise)
        {
            YearsExperience = yearsexperience;
            Specialisation = specialisation;
            DateofBirth = DOB;
        }
        public int YearsExperience { get; set; }
        public ESpecialisation Specialisation { get; set; }
        public DateTime DateofBirth { get; set; }

        public override string ToString()
        {
            StringBuilder juniorlawyerstats = new StringBuilder();
            juniorlawyerstats.AppendLine(base.ToString());
            juniorlawyerstats.AppendLine($"Date of Birth is; {DateofBirth.ToString("dd.MM.yyyy")}");
            juniorlawyerstats.AppendLine($"Years Experience are: {YearsExperience}");
            juniorlawyerstats.AppendLine($"Specialisation is: {Specialisation}");

            return juniorlawyerstats.ToString();
        }
    }
}
