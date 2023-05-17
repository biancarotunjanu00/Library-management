using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Reflection.Metadata;

namespace E_Library.Models
{
    public class LibraryContext : DbContext

    {

        public LibraryContext(DbContextOptions<LibraryContext> options)
        : base(options)

        { }

        public DbSet<Book>? Books { get; set; }
        public DbSet<MyBook>? MyBooks { get; set; }
        public DbSet<Review>? Reviews { get; set; }
        public DbSet<Subject>? Subjects { get; set; }
        public DbSet<User>? Users { get; set; }

    }
}
