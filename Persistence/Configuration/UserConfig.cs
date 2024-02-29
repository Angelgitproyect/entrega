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
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(e => e.id);
            builder.ToTable("user");
            builder.Property(e => e.id).HasColumnName("iduser");

            builder.Property(e => e.name).HasColumnName("nameuser");
            builder.Property(e => e.dni).HasColumnName("dni");
        }
    }
}
