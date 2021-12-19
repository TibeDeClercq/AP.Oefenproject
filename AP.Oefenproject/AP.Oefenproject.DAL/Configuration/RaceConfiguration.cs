using System;
using System.Collections.Generic;
using System.Text;
using AP.Oefenproject.DAL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AP.Oefenproject.DAL.Configuration
{
    public class RaceConfiguration : IEntityTypeConfiguration<Race>
    {
        public void Configure(EntityTypeBuilder<Race> builder)
        {
            builder.ToTable("tblRaces", "Race")
                .HasKey(p => p.Race_id);

            builder.HasOne(s => s.Season)
                .WithMany(p => p.Races)
                .HasForeignKey(f => f.Season_id);

            builder.HasOne(s => s.Circuit)
                .WithMany(p => p.Races)
                .HasForeignKey(f => f.Circuit_id);

            builder.Property(p => p.Race_name)
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
        }
    }
}
