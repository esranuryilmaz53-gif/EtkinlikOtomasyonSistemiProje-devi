using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace EtkinlikOtomasyonSistemi
{
    public class EventManager
    {
        private string filePath = "events.json";
        public List<Event> Events { get; set; }

        public EventManager() { LoadEvents(); }

       private void LoadEvents()
{
    try
    {
        
        if (File.Exists(filePath))
        {
            string jsonString = File.ReadAllText(filePath);
            Events = JsonSerializer.Deserialize<List<Event>>(jsonString) ?? new List<Event>();
        }
        else { Events = new List<Event>(); }
    }
    catch (Exception)
    {
        
        MessageBox.Show("Geçmiş etkinlikler yüklenemedi, temiz bir sayfa açılıyor.");
        Events = new List<Event>();
    }
}


public void SaveEvents()
{
    try
    {
       
        string jsonString = JsonSerializer.Serialize(Events, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, jsonString);
    }
    catch (Exception)
    {
        
        MessageBox.Show("Bilgiler dosyaya kaydedilemedi! Lütfen bilgisayarınızda yer olduğundan emin olun.");
    }
}

        public void AddEvent(string name, string time, string location, string organizer)
        {
            int newId = Events.Count > 0 ? Events[Events.Count - 1].Id + 1 : 1;
            Events.Add(new Event { Id = newId, Name = name, Time = time, Location = location, Organizer = organizer });
            SaveEvents();
        }

        public string JoinEvent(int eventId, string username)
        {
            Event ev = Events.Find(e => e.Id == eventId);
            if (ev == null) return "Etkinlik bulunamadı.";
            if (ev.JoinedUsers.Contains(username)) return "Bu etkinliğe zaten kayıtlısınız!";

            ev.JoinedUsers.Add(username);
            SaveEvents();
            return "Başarıyla kayıt oldunuz!";
        }

        
        public string LeaveEvent(int eventId, string username)
        {
            Event ev = Events.Find(e => e.Id == eventId);
            if (ev != null && ev.JoinedUsers.Contains(username))
            {
                ev.JoinedUsers.Remove(username); 
                SaveEvents(); 
                return "Etkinlikten ayrıldınız.";
            }
            return "Kayıt bulunamadı.";
        }
    }
}
