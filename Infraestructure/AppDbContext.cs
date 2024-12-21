using Microsoft.EntityFrameworkCore;
using Domain;

namespace Infraestructure
{
    public class AppDbContext : DbContext
    {
        //Entities
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Country> Countries { get; set; }


        //Connection
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-BCQFL9J\\SQLEXPRESS; " +
                "Database=DBExamenApp; Integrated Security=True;" +
                "Trust Server Certificate=True ");
        }
    }
}
