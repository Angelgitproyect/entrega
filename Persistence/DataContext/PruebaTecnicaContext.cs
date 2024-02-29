using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Persistence.DataContext

{
    public class PruebaTecnicaContext : DbContext
    {
        public PruebaTecnicaContext(DbContextOptions<PruebaTecnicaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cars> Cars { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<LocationRental> LocationRental { get; set; }
        public virtual DbSet<Locations> Locations { get; set; }
        public virtual DbSet<VehicleRental> VehicleRental { get; set; }
        public virtual DbSet<LogApplication> LogApplication { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
