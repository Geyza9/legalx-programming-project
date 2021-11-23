using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace legalxproject
{
    // appointment class
    class Appointments
    {
        public int appointmentid { get; set; }
        public int clientid { get; set; }
        public int lawyerid { get; set; }
        public DateTime dateandtime { get; set; }
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
