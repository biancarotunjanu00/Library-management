using System.Xml.Linq;

namespace E_Library.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

        public ICollection<MyBook>? MyBooks { get; set; }
        public ICollection<Review>? Reviews { get; set; }

    }
}
