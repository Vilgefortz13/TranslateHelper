using Microsoft.EntityFrameworkCore;

namespace WebTranslateHelper.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Sentence> Sentences = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) 
        {
            Database.EnsureCreated();
        }
    }
}
