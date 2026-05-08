using LoginNexus.Models;

namespace LoginNexus.Services
{
    public class AuthService
    {
        private readonly List<User> _users = new()
    {
        new User { Email = "professor@nexus.edu", Password = "123", Role = "Professor", Name = "Dr. Arnaldo" },
        new User { Email = "Arthur@nexus.edu", Password = "123", Role = "Student", Name = "Kyldare" }
    };

        public User? Authenticate(string email, string password)
        {
            return _users.FirstOrDefault(u => u.Email == email && u.Password == password);
        }
    }
}