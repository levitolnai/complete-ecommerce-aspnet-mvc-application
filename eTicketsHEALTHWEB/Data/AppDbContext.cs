using eTicketsHEALTHWEB.Models;
using Microsoft.EntityFrameworkCore;

namespace eTicketsHEALTHWEB.Data
{
    public class AppDbContext: DbContext//Translator between your Model Classes and Database
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }
        //default authentication table - we don't need to have manually define identifiers
        protected override void OnModelCreating(ModelBuilder modelBuilder )
        {
            modelBuilder.Entity<Doctor_VirusName>().HasKey(dv => new
            {
                dv.DoctorId,
                dv.VirusNameId
            });
            modelBuilder.Entity<Doctor_VirusName>().HasOne(v => v.VirusName).WithMany(dv => dv.Doctors_VirusNames).HasForeignKey(v => v.VirusNameId);

            modelBuilder.Entity<Doctor_VirusName>().HasOne(v => v.Doctor).WithMany(dv => dv.Doctors_VirusNames).HasForeignKey(v => v.DoctorId);

            
            base.OnModelCreating(modelBuilder);     
        }
        //last thing need to do is to define the table names for each model

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<VirusName> VirusNames { get; set; }
        public DbSet<Doctor_VirusName> Doctors_VirusNames { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Company> Companys { get; set; }

        //Orders related tables
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        
    }
}
