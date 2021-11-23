using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace legalxproject
{
    // This is the Base Class for employee types
    public class Employee
    {
        public Employee(int id, string name,  DateTime joineddate, string otherexpertise)
        {
            EmployeeId = id;
            FullName = name;
            JoinedDate = joineddate;
            OtherExpertise = otherexpertise;
        }

        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public DateTime JoinedDate { get; set; }
        public string OtherExpertise{ get; set; }

        public override string ToString()
        {
            StringBuilder basicemployeeinfo = new StringBuilder();
            basicemployeeinfo.AppendLine("******* Here are the Employee Details ********");
            basicemployeeinfo.AppendLine($" Employee ID is: {EmployeeId}");
            basicemployeeinfo.AppendLine($" Employees Full Name is: {FullName}");
            basicemployeeinfo.AppendLine($" Joined LegalX on: {JoinedDate.ToString("ddMMyyyy")}");
            basicemployeeinfo.AppendLine($" Expertise in: {OtherExpertise}");

            return basicemployeeinfo.ToString();
        }
    }
    
}
