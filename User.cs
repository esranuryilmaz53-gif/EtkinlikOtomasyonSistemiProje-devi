using System.Windows.Forms;

namespace EtkinlikOtomasyonSistemi
{
    public abstract class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public abstract string Role { get; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public abstract Form GetDashboardForm(EventManager eventManager, UserManager userManager);
    }

    public class Admin : User
    {
        public override string Role => "Admin";
        public Admin(string username, string password) : base(username, password) { }
        public override Form GetDashboardForm(EventManager eventManager, UserManager userManager) => new AdminForm(userManager, this.Username);
    }

    public class Student : User
    {
        public override string Role => "Öğrenci";
        public Student(string username, string password) : base(username, password) { }
        public override Form GetDashboardForm(EventManager eventManager, UserManager userManager) => new StudentForm(eventManager, this.Username);
    }

    public class ClubPresident : User
    {
        public string ClubName { get; set; }
        public override string Role => "Kulüp Başkanı";
        public ClubPresident(string username, string password, string clubName) : base(username, password) { ClubName = clubName; }
        public override Form GetDashboardForm(EventManager eventManager, UserManager userManager) => new PresidentForm(eventManager, ClubName);
    }
}