using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration
{
    public class CarsConfig : IEntityTypeConfiguration<Cars>
    {
        public void Configure(EntityTypeBuilder<Cars> builder)
        {
            builder.HasKey(e => e.id);
            builder.ToTable("cars");
            builder.Property(e => e.id).HasColumnName("idcar");

            builder.Property(e => e.plate).HasColumnName("plate");
            builder.Property(e => e.plateCity).HasColumnName("platecity");
            builder.Property(e => e.brand).HasColumnName("brand");

        }
    }
}
