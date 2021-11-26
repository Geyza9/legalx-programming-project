using System;
using System.Text;

namespace legalxproject
{
    // appointment class
    class Appointments
    {
        public Appointments() {  }

        public Appointments(int appointmentid, int clientid, int lawyerid, DateTime dateandtime, string meetingroom, string shortdescription)
        {
            this.appointmentid = appointmentid;
            this.clientid = clientid;
            this.lawyerid = lawyerid;
            this.dateandtime = dateandtime;
            this.meetingroom = meetingroom;
            this.shortdescription = shortdescription;
        }

        public int appointmentid { get; set; }
        public int clientid { get; set; } 
        public int lawyerid { get; set; }
        public DateTime dateandtime { get; set; } = new DateTime(0001, 01, 01, 00, 00, 00); //default value used to check if the actual date time was applied
        public string meetingroom { get; set; }
        public string shortdescription { get; set; }

        public override string ToString()
        {
            StringBuilder appointmentdetails = new StringBuilder();
            appointmentdetails.AppendLine("********* Appointment Information*********");
            appointmentdetails.AppendLine($"Appointment ID: {appointmentid}");
            appointmentdetails.AppendLine($"Client ID: {clientid}");
            appointmentdetails.AppendLine($"Lawyer ID: {lawyerid}");
            appointmentdetails.AppendLine($"Date and time of appointment: {dateandtime.ToString("dd/MM/yyyy HH:mm")}");
            appointmentdetails.AppendLine($"Meeting room: {meetingroom}");
            appointmentdetails.AppendLine($"Short Description {shortdescription}");

            return appointmentdetails.ToString();
        }
    }
}
