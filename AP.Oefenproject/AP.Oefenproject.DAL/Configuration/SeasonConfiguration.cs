using System;
using System.Collections.Generic;
using System.Text;
using AP.Oefenproject.DAL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AP.Oefenproject.DAL.Configuration
{
    public class SeasonConfiguration : IEntityTypeConfiguration<Season>
    {
        public void Configure(EntityTypeBuilder<Season> builder)
        {
            builder.ToTable("tblSeasons", "Season")
                .HasKey(p => p.Season_id);

            builder.HasOne(s => s.Serie)
                .WithMany(p => p.Seasons)
                .HasForeignKey(f => f.Serie_id);

            builder.Property(p => p.Season_name)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(30);

            builder.Property(p => p.Start_date)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(10);

            builder.Property(p => p.End_date)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(10);

            builder.Property(p => p.Active)
                .IsRequired()
                .HasColumnType("bit");
        }
    }
}
