using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration
{
    public class CityConfig : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(e => e.id);
            builder.ToTable("city");
            builder.Property(e => e.id).HasColumnName("idcity");

            builder.Property(e => e.name).HasColumnName("name");
        }
    }
}
