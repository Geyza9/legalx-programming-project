using System;
using System.Text;

namespace legalxproject
{
    class Cases
    {
        public Cases() { }

        public Cases(int caseid, int clientid, ESpecialisation casetype, DateTime startdate, string expectedprocessduration, int totalcharges, int lawyerid, string situationdescription, string othernotes)
        {
            this.caseid = caseid;
            this.clientid = clientid;
            this.casetype = casetype;
            this.startdate = startdate;
            this.expectedprocessduration = expectedprocessduration;
            this.totalcharges = totalcharges;
            this.lawyerid = lawyerid;
            this.situationdescription = situationdescription;
            this.othernotes = othernotes;
        }

        public int caseid { get; set; }
        public int clientid { get; set; }
        public ESpecialisation casetype { get; set; }
        public DateTime startdate { get; set; } = new DateTime(0001, 01, 01);
        public string expectedprocessduration { get; set; }
        public int totalcharges { get; set; } = -1; //setting a never used value to determine later if the variable was successfully set by user
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
