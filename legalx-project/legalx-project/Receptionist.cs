using System;
using System.Text;

namespace legalxproject
{
    //Fourth Child class of employee
    class Receptionist : Employee
    {
        public Receptionist(int id, string fullname, DateTime joineddate, string otherexpertise) : base(id, fullname, joineddate, otherexpertise)
        {
            
        }
        public override string ToString()
        {
            StringBuilder Receptioniststats = new StringBuilder();
            Receptioniststats.AppendLine(base.ToString());

            return Receptioniststats.ToString();
        }
    }
}
