using System.Collections.Generic;

namespace EtkinlikOtomasyonSistemi

{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
        public string Location { get; set; }
        public string Organizer { get; set; }
        public List<string> JoinedUsers { get; set; } = new List<string>();

        public Event() { }
    }
}