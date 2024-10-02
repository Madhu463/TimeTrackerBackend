using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TrackMaster.Models
{

    [Table("Hours")]
    public class Hours
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Employees")]
        public int EmployeeId { get; set; }
        public Employees Employee { get; set; }

        [Required]
        public int HoursWorked { get; set; }
    }
}
