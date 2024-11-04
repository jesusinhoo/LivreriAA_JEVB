using LivreriAA_JEVB.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace LivreriAA_JEVB.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
