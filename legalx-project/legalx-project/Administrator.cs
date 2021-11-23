using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace legalxproject
{
    //third Child class of employee
    class Administrator : Employee
    {
        public Administrator(int id, string fullname, DateTime joineddate, string otherexpertise, string role) : base(id, fullname, joineddate, otherexpertise)
        {
            Role = role;
        }

        public string Role { get; set; }


        public override string ToString()
        {
            StringBuilder administratorstats = new StringBuilder();
            administratorstats.AppendLine(base.ToString());
            administratorstats.AppendLine($"current role: {Role}");

            return administratorstats.ToString();
        }
    }
}
