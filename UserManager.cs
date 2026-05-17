using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace EtkinlikOtomasyonSistemi
{
    
    public class UserData
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string ClubName { get; set; }
    }

    public class UserManager
    {
        private string filePath = "users.json";
        public List<User> Users { get; set; }

        public UserManager()
        {
            LoadUsers();
        }

        
        private void LoadUsers()
        {
            Users = new List<User>();

            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                var savedUsers = JsonSerializer.Deserialize<List<UserData>>(jsonString) ?? new List<UserData>();

                foreach (var u in savedUsers)
                {
                    if (u.Role == "Admin") Users.Add(new Admin(u.Username, u.Password));
                    else if (u.Role == "Kulüp Başkanı") Users.Add(new ClubPresident(u.Username, u.Password, u.ClubName));
                    else Users.Add(new Student(u.Username, u.Password));
                }
            }

            
            if (Users.Count == 0)
            {
                Users.Add(new Admin("EsranurYılmaz", "esra123"));
                Users.Add(new Admin("ElifBeyzaYıldız", "elif123"));
                Users.Add(new Student("AhmetOgrenci", "0000"));
                SaveUsers();
            }
        }

        
        public void SaveUsers()
        {
            var dataToSave = Users.Select(u => new UserData
            {
                Username = u.Username,
                Password = u.Password,
                Role = u.Role,
                ClubName = u is ClubPresident cp ? cp.ClubName : ""
            }).ToList();

            string jsonString = JsonSerializer.Serialize(dataToSave, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, jsonString);
        }

        public User Login(string username, string password) => Users.FirstOrDefault(u => u.Username == username && u.Password == password);

        
        public bool Register(string username, string password)
        {
            if (Users.Any(u => u.Username.ToLower() == username.ToLower())) return false;
            Users.Add(new Student(username, password));
            SaveUsers();
            return true;
        }

       
        public bool PromoteToPresident(string username, string clubName)
        {
            User foundUser = Users.Find(u => u.Username.ToLower() == username.ToLower());
            if (foundUser != null && foundUser is Student)
            {
                Users.Remove(foundUser);
                Users.Add(new ClubPresident(foundUser.Username, foundUser.Password, clubName));
                SaveUsers();
                return true;
            }
            return false;
        }

        public object GetUserListForAdmin()
        {
            return Users.Where(u => !(u is Admin))
                        .Select(u => new { KullanıcıAdı = u.Username, Görevi = u is ClubPresident cp ? $"{u.Role} ({cp.ClubName})" : u.Role })
                        .ToList();
        }
    }
}