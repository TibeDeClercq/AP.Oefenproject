using System;
using System.Collections.Generic;
using System.Text;
using AP.Oefenproject.DAL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AP.Oefenproject.DAL.Configuration
{
    public class RacePilotTeamConfiguration : IEntityTypeConfiguration<RacePilotTeam>
    {
        public void Configure(EntityTypeBuilder<RacePilotTeam> builder)
        {
            builder.ToTable("tblRacePilotTeams", "RacePilotTeam")
                .HasKey(p => new { p.Pilot_id, p.Race_id });

            builder.HasOne(s => s.Pilot)
                .WithMany(p => p.RacePilotTeams)
                .HasForeignKey(f => f.Pilot_id);

            builder.HasOne(s => s.Race)
                .WithMany(p => p.RacePilotTeams)
                .HasForeignKey(f => f.Race_id);

            builder.HasOne(s => s.Team)
                .WithMany(p => p.RacePilotTeams)
                .HasForeignKey(f => f.Team_id);
        }
    }
}
