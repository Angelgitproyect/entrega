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
    public class LogApplicationConfig : IEntityTypeConfiguration<LogApplication>
    {
        public void Configure(EntityTypeBuilder<LogApplication> builder)
        {
            builder.HasKey(e => e.id);
            builder.ToTable("logsystem");
            builder.Property(e => e.id).HasColumnName("idlogsystem");

            builder.Property(e => e.detail).HasColumnName("detail");
            builder.Property(e => e.title).HasColumnName("title");
            builder.Property(e => e.status).HasColumnName("statuslogsystem");
            builder.Property(e => e.logDate).HasColumnName("logdate");
        }
    }
}
