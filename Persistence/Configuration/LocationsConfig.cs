using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration
{
    public class LocationsConfig : IEntityTypeConfiguration<Locations>
    {
        public void Configure(EntityTypeBuilder<Locations> builder)
        {
            builder.HasKey(e => e.id);
            builder.ToTable("locations");
            builder.Property(e => e.id).HasColumnName("idlocations");

            builder.Property(e => e.name).HasColumnName("namelocations");
            builder.Property(e => e.latitud).HasColumnName("lat");
            builder.Property(e => e.longitude).HasColumnName("lon");
            builder.Property(e => e.idCity).HasColumnName("idcity");

            builder.HasOne(e => e.idCityNavigation)
              .WithMany(e => e.Locations)
              .HasForeignKey(e => e.idCity)
              .OnDelete(DeleteBehavior.ClientSetNull)
              .HasConstraintName("fk_loca_city");
        }
    }
}
