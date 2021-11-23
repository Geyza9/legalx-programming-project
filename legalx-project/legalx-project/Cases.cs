using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace legalxproject
{
    class Cases
    {
        public int caseid { get; set; }
        public int clientid { get; set; }
        public string casetype { get; set; }
        public DateTime startdate { get; set; }
        public string expectedprocessduration { get; set; }
        public int totalcharges { get; set; }
        public int lawyerid { get; set; }
        public string situationdescription { get; set; }
        public string othernotes { get; set; }

        public override string ToString()
        {
            StringBuilder casedetails = new StringBuilder();
            casedetails.AppendLine("********* Case ID Information*********");
            casedetails.AppendLine($"Case ID: {caseid}");
            casedetails.AppendLine($"Client ID: {clientid}");
            casedetails.AppendLine($"Lawyer ID: {lawyerid}");
            casedetails.AppendLine($"Case type: {casetype}");
            casedetails.AppendLine($"Start date: {startdate.ToString("dd/MM/yyyy")}");
            casedetails.AppendLine($"Expected processduration: {expectedprocessduration}");
            casedetails.AppendLine($"Situation: {situationdescription}");
            casedetails.AppendLine($"Othernotes: {othernotes}");

            return casedetails.ToString();
        }
    }
}
