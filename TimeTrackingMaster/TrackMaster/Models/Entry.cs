using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace TrackMaster.Models
{

    [Table("Entry")]
    public class Entry
    {
        [Key]
        public int Id { get; set; }
        
        [ForeignKey("Employees")]
        public int EmployeeId { get; set; }
        public Employees Employee { get; set; }

        [ForeignKey("Activities")]
        public int ActivityId { get; set; }
        public Activities Activity { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int Hours { get; set; }
    }
}
