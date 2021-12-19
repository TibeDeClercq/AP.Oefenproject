using System;
using System.Collections.Generic;
using System.Text;
using AP.Oefenproject.DAL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AP.Oefenproject.DAL.Configuration
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("tblCountries", "Country")
                .HasKey(p => p.Country_id);

            builder.Property(p => p.Country_name)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(30);
        }
    }
}
