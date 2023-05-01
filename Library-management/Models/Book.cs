using System.Security.Cryptography.X509Certificates;

namespace E_Library.Models
{
    public class Book
    {
 

        public int BookId { get; set; }
        public string? Book_Title { get; set; }
        public string? Book_Author { get; set; }
        public string? Description { get; set; }
        public string? Published { get; set; }

        public int SubjectId { get; set; }
        public Subject? Subject { get; set; }

        public ICollection<Review>? Reviews { get; set; }
        public ICollection<MyBook>? Mybooks { get; set; }


    }
}
