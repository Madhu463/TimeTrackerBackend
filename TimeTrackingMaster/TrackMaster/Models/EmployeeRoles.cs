using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TrackMaster.Models
{

    [Table("EmployeeRoles")]
    public class EmployeeRoles
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string RoleName { get; set; }

        [MaxLength(500)]
        public string RoleDescription { get; set; }

        // Navigation property
        public ICollection<Employees> Employee  { get; set; }
    }
}
