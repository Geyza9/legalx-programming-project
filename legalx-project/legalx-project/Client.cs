using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace legalxproject
{// client class
    class Client
    {
        public int clientid { get; set; }
        public string firstname { get; set; }
        public string middlename { get; set; }
        public string lastname { get; set; }
        public DateTime DOB { get; set; }
        public string casetype { get; set; }
        public string street { get; set; }
        public int streetnr { get; set; }
        public int zip { get; set; }
        public string city { get; set; }


        public override string ToString()
        {
            StringBuilder clientstats = new StringBuilder();
            clientstats.AppendLine("********* Client Information*********");
            clientstats.AppendLine($"Client ID: {clientid}");
            clientstats.AppendLine($"Clients Name is {firstname} {middlename} {lastname}");
            clientstats.AppendLine($"Date of Birth is: {DOB.ToString("ddMMyyyy")}");
            clientstats.AppendLine($"Case type: {casetype}");
            clientstats.AppendLine($"Address: {street} {streetnr}, {zip}, {city}"); 

            return clientstats.ToString();
        }
    }

    }

}
