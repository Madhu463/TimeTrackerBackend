using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace TrackMaster.Models
{

    [Table("Team")]
    public class Team
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        // Navigation properties
        public ICollection<EmployeeTeams> EmployeeTeam { get; set; }
        public ICollection<Activities> Activity { get; set; }
        public ICollection<TeamMembers> TeamMember { get; set; }
    }
}
