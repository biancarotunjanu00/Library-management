using System.Reflection.Metadata;

namespace E_Library.Models
{
    public class Subject
    {

        public int SubjectId { get; set; }
        public string? Subject_Name { get; set; }

        public ICollection<Book>? Books { get; set; }
    }
}
