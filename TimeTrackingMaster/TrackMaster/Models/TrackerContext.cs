using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Transactions;

namespace TrackMaster.Models
{
    public class TrackerContext : DbContext

    {

        public TrackerContext(DbContextOptions<TrackerContext> options) : base(options)
        {

        }
        public DbSet<Activities> Activity { get; set; }
        public DbSet<EmployeeRoles> EmployeeRole { get; set; }
        public DbSet<Employees> Employee { get; set; }
        public DbSet<EmployeeTeams> EmployeeTeam { get; set; }
        public DbSet<Entry> Entries { get; set; }
        public DbSet<Hours> Hour { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<TeamMemberRoles> TeamMemberRole { get; set; }
        public DbSet<TeamMembers> TeamMember { get; set; }
    }
}
