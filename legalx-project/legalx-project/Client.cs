using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace legalxproject
{// client class
    class Client
    {
        // some properties have a default value assigned, which are used to confirm if the value has been successfully set
        public int clientid { get; set; }
        public string firstname { get; set; }
        public string middlename { get; set; }
        public string lastname { get; set; }
        public DateTime DOB { get; set; } = new DateTime(0001,01,01);
        public ESpecialisation casetype { get; set; }
        public string street { get; set; }
        public string streetnr { get; set; } //is a string as some street numbers might have letters (e.g. 12A)
        public int zip { get; set; } = 0;
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
