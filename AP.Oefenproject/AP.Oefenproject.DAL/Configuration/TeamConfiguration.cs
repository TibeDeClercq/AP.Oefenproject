using System;
using System.Collections.Generic;
using System.Text;
using AP.Oefenproject.DAL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AP.Oefenproject.DAL.Configuration
{
    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.ToTable("tblTeams", "Team")
                .HasKey(p => p.Team_id);

            builder.Property(p => p.Team_name)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(30);
        }
    }
}
