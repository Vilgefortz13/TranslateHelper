using Microsoft.EntityFrameworkCore;
using WebTranslateHelper.Models.Entities;

namespace WebTranslateHelper.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Sentence> Sentences { get; set; }
    }
}
