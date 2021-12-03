using System;
using System.Text;

namespace legalxproject
{// client class
    class Client
    {

        public Client()
        {

        }

        public Client(int id, string firstname, string middlename, string lastname, DateTime DOB, ESpecialisation casetype, string street, string streetnr, string zip, string city)
        {
            clientid = id;
            this.firstname = firstname;
            this.middlename = middlename;
            this.lastname = lastname;
            this.DOB = DOB;
            this.casetype = casetype;
            this.street = street;
            this.streetnr = streetnr;
            this.zip = zip;
            this.city = city;
        }

        // some properties have a default value assigned, which are used to confirm if the value has been successfully set
        public int clientid { get; set; }
        public string firstname { get; set; }
        public string middlename { get; set; }
        public string lastname { get; set; }
        public DateTime DOB { get; set; } = new DateTime(0001,01,01);
        public ESpecialisation casetype { get; set; }
        public string street { get; set; }
        public string streetnr { get; set; } //is a string as some street numbers might have letters (e.g. 12A)
        public string zip { get; set; } // also a string because some zip codes in foreign countries have letters in them
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
