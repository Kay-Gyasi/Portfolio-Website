using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.DBContext
{
    public class PortfolioContext: DbContext
    {
        public PortfolioContext()
        {

        }

        public PortfolioContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Admin> Admins { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Projects> Projects { get; set; }

        public DbSet<Skills> Skills { get; set; }

        public DbSet<Interactions> Interactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=YOGA-X1;Database=PortfolioSite;Trusted_Connection=True;");
            }
        }

    }
}
