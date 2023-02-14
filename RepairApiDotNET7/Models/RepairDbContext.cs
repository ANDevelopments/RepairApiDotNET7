using Microsoft.EntityFrameworkCore;
namespace RepairApiDotNET7.Models
{
    public class RepairDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Serv> Servs { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Document> Documents { get; set; }

        public DbSet<Progress> Progress { get; set; }
        public DbSet<Register> Register { get; set; }

        public RepairDbContext(DbContextOptions<RepairDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<Serv>().ToTable("Serv");
            modelBuilder.Entity<Orders>().ToTable("Orders");
            modelBuilder.Entity<Document>().ToTable("Document");
            modelBuilder.Entity<Progress>().ToTable("Progress");
            modelBuilder.Entity<Register>().ToTable("Register");
        }
    }
}
