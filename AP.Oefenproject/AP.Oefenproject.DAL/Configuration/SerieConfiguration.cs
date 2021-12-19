using System;
using System.Collections.Generic;
using System.Text;
using AP.Oefenproject.DAL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AP.Oefenproject.DAL.Configuration
{
    public class SerieConfiguration : IEntityTypeConfiguration<Serie>
    {
        public void Configure(EntityTypeBuilder<Serie> builder)
        {
            builder.ToTable("tblSeries", "Serie")
                .HasKey(p => p.Serie_id);

            builder.Property(p => p.Serie_name)
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

            builder.Property(p => p.Sort_order)
                .IsRequired()
                .HasColumnType("int")
                .HasMaxLength(9);
        }
    }
}
