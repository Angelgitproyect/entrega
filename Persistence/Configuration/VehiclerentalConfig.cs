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
    public class VehiclerentalConfig : IEntityTypeConfiguration<VehicleRental>
    {
        public void Configure(EntityTypeBuilder<VehicleRental> builder)
        {
            builder.HasKey(e => e.id);
            builder.ToTable("vehiclerental");
            builder.Property(e => e.id).HasColumnName("idvehiclerental");

            builder.Property(e => e.idCar).HasColumnName("idcar");
            builder.Property(e => e.idUser).HasColumnName("iduser");
            builder.Property(e => e.rented).HasColumnName("rented");

            builder.HasOne(e => e.idUserNavigation)
               .WithMany(e => e.VehicleRental)
               .HasForeignKey(e => e.idUser)
               .OnDelete(DeleteBehavior.ClientSetNull)
               .HasConstraintName("fk_vere_user");

            builder.HasOne(e => e.idCarsNavigation)
               .WithMany(e => e.VehicleRental)
               .HasForeignKey(e => e.idCar)
               .OnDelete(DeleteBehavior.ClientSetNull)
               .HasConstraintName("fk_vere_car");
        }
    }
}
