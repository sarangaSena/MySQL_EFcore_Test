using Microsoft.EntityFrameworkCore;
using MySQL_EFcore_Test.Models;

namespace MySQL_EFcore_Test.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }

        public DbSet<Category>? Categories { get; set; }
    }
}
