using Microsoft.EntityFrameworkCore;
using Relations.Entites.ManyToMany;
using Relations.Entites.OneToMany;
using Relations.Entites.OneToOne;

namespace Relations.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Citizen> Citizens { get; set; }
        public DbSet<Passport> Passports { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=JESUS;Database=Dma06db;Integrated Security=true;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }

     
    }
}
