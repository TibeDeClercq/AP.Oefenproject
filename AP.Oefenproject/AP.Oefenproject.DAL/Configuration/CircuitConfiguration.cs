using System;
using System.Collections.Generic;
using System.Text;
using AP.Oefenproject.DAL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AP.Oefenproject.DAL.Configuration
{
    public class CircuitConfiguration : IEntityTypeConfiguration<Circuit>
    {
        public void Configure(EntityTypeBuilder<Circuit> builder)
        {
            builder.ToTable("tblCircuits", "Circuit")
                .HasKey(p => p.Circuit_id);

            builder.HasOne(s => s.Country)
                .WithMany(p => p.Circuits)
                .HasForeignKey(f => f.Country_id);

            builder.Property(p => p.Circuit_name)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(30);

            builder.Property(p => p.Province)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(60);

            builder.Property(p => p.City)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(60);

            builder.Property(p => p.Street)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(60);

            builder.Property(p => p.House_number)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(5);

            builder.Property(p => p.Length)
                .IsRequired()
                .HasColumnType("int")
                .HasMaxLength(5);
        }
    }
}
