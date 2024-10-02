using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TrackMaster.Models
{


    [Table("TeamMembers")]
    public class TeamMembers
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Team")]
        public int TeamId { get; set; }
        public Team Team { get; set; }

        [ForeignKey("Employees")]
        public int EmployeeId { get; set; }
        public Employees Employee { get; set; }

        [ForeignKey("TeamMemberRoles")]
        public int RoleId { get; set; }
        public TeamMemberRoles TeamMemberRole { get; set; }
    }
}
