using System.Text;

namespace legalxproject
{
    //meeting room class
    class MeetingRooms
    {
        public MeetingRooms(string name, int capacity)
        {
            this.name = name;
            this.capacity = capacity;
        }

        public string name { get; set; }
        public int capacity { get; set; }

        public override string ToString()
        {
            StringBuilder meetingroomstats = new StringBuilder();
            //meetingroomstats.AppendLine("*********  Meeting Room Information *********");
            meetingroomstats.AppendLine($"Meeting room name: {name}");
            meetingroomstats.AppendLine($"Occupancy limit: {capacity}");

            return meetingroomstats.ToString();
        }
    }
}
