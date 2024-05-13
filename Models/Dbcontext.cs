using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Models
{
    public class Dbcontext:DbContext
    {
        public Dbcontext()
        {
        }
        public Dbcontext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Patron> Patrons { get; set; }
        public DbSet<BorrowingRecord> BorrowingRecords { get; set; }

    }
}
