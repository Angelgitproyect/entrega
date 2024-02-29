using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Configuration
{
    public class LocationRentalConfig : IEntityTypeConfiguration<LocationRental>
    {
        public void Configure(EntityTypeBuilder<LocationRental> builder)
        {
            builder.HasKey(e => e.id);
            builder.ToTable("locationrental");
            builder.Property(e => e.id).HasColumnName("idlocationrental");

            builder.Property(e => e.idVehicleRental).HasColumnName("idvehiclerental");
            builder.Property(e => e.idLocations).HasColumnName("idlocations");

            builder.HasOne(e => e.idVehiclerentalNavigation)
              .WithMany(e => e.LocationRental)
              .HasForeignKey(e => e.idVehicleRental)
              .OnDelete(DeleteBehavior.ClientSetNull)
              .HasConstraintName("fk_lore_vere");

            builder.HasOne(e => e.idLocationsNavigation)
             .WithMany(e => e.LocationRental)
             .HasForeignKey(e => e.idLocations)
             .OnDelete(DeleteBehavior.ClientSetNull)
             .HasConstraintName("fk_lore_loca");
        }
    }
}
