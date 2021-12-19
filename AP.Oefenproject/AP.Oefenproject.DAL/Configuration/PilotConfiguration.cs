using System;
using System.Collections.Generic;
using System.Text;
using AP.Oefenproject.DAL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AP.Oefenproject.DAL.Configuration
{
    public class PilotConfiguration : IEntityTypeConfiguration<Pilot>
    {
        public void Configure(EntityTypeBuilder<Pilot> builder)
        {
            builder.ToTable("tblPilots", "Pilot")
                .HasKey(p => p.Pilot_id);

            builder.HasIndex(p => p.License_nr).IsUnique();

            builder.Property(p => p.License_nr)
                .IsRequired()
                .HasColumnType("int")
                .HasMaxLength(9);

            builder.Property(p => p.Name)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(30);

            builder.Property(p => p.Surname)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(60);

            builder.Property(p => p.Nickname)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(30);

            builder.Property(p => p.Gender)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(1);

            builder.Property(p => p.Date_of_birth)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(10);

            builder.Property(p => p.Length)
                .IsRequired()
                .HasColumnType("int")
                .HasMaxLength(3);

            builder.Property(p => p.Weight)
                .IsRequired()
                .HasColumnType("int")
                .HasMaxLength(3);

            builder.Property(p => p.Picture_path)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(100);
        }
    }
}
