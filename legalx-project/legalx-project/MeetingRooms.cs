using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace legalxproject
{
    //Meeting room class
    class MeetingRooms
    {
        public string name { get; set; }
        public int capacity { get; set; }

        public override string ToString()
        {
            StringBuilder meetingroomstats = new StringBuilder();
            meetingroomstats.AppendLine("*********  Meeting Room Information *********");
            meetingroomstats.AppendLine($"Meeting room name: {name}");
            meetingroomstats.AppendLine($"Occupancy limit: {capacity}");

            return meetingroomstats.ToString();
        }
    }
}
