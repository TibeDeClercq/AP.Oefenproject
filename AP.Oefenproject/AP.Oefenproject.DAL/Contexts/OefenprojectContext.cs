using AP.Oefenproject.DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AP.Oefenproject.DAL.Contexts
{
    public class OefenprojectContext : DbContext
    {
        public OefenprojectContext(DbContextOptions<OefenprojectContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Circuit> Circuits { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Pilot> Pilots { get; set; }

        public DbSet<Race> Races { get; set; }

        public DbSet<RacePilotTeam> RacePilotTeams { get; set; }

        public DbSet<Season> Seasons { get; set; }

        public DbSet<Serie> Series { get; set; }

        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //builder.Seeding();
        }
    }
}
