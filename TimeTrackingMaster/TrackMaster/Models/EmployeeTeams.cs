using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TrackMaster.Models
{
    [Table("EmployeeTeams")]
    public class EmployeeTeams
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Employees")]
        public int EmployeeId { get; set; }
        public Employees Employee { get; set; }

        [ForeignKey("Team")]
        public int TeamId { get; set; }
        public Team Team { get; set; }
    }
}
