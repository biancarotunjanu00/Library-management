using System.ComponentModel.DataAnnotations;

namespace E_Library.Models
{
    public class Article
    {
       public int ArticleId { get; set; }

        public string? Article_Title { get; set; }
        public string? Article_Author { get; set; }
        public string? Content { get; set; }
        public DateTime? Date { get; set; }

    }
}
