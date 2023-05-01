namespace E_Library.Models
{
    public class MyBook
    {
        public int MyBookId { get; set; }


        public int BookId { get; set; }
        public Book? Book { get; set; }

        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
