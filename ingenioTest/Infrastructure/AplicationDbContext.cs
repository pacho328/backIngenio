using ingenioTest.Models;
using Microsoft.EntityFrameworkCore;

namespace ingenioTest.Infrastructure
{
    public class AplicationDbContext: DbContext
    {
        public DbSet<Book> Book { get; set; }
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options) 
        {
            
        }
    }
}
