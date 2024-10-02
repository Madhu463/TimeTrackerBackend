using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TrackMaster.Models
{

    [Table("Employees")]
    public class Employees
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string FirstName { get; set; }

        [Required, MaxLength(100)]
        public string LastName { get; set; }

        [Required, MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(15)]
        public string Phone { get; set; }

        [Required]
        public DateTime HireDate { get; set; }

        [ForeignKey("EmployeeRoles")]
        public int RoleId { get; set; }
        public EmployeeRoles EmployeeRole { get; set; }

        // Navigation properties
        public ICollection<EmployeeTeams> EmployeeTeam { get; set; }
        public ICollection<Entry> Entries { get; set; }
        public ICollection<Hours> Hour { get; set; }
    }
    
}
