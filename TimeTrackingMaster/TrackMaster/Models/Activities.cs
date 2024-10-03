using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TrackMaster.Models
{


    [Table("Activities")]
    public class Activities
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(200)]
        public string TaskName { get; set; }

        [ForeignKey("Employees")]
        public int CreatedBy { get; set; }
        public Employees Employee { get; set; }

        [ForeignKey("Team")]
        public int TeamId { get; set; }
        public Team Team { get; set; }

        public bool Utilization { get; set; }

        [ForeignKey("Hours")]
        public int? HoursId { get; set; }
        public Hours Hour { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }
        public ICollection<Entry> Entries { get; set; }

    
}
}


