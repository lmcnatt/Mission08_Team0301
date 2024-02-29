using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission08_Team0301.Models
{
    public class Job
    {
        [Key]
        [Required]
        public int JobId { get; set; }

        [Required]
        public string JobName { get; set; }

        public string? DueDate { get; set; }

        [Required]
        public int Quadrant { get; set; }

        public string? Category { get; set; }

        [Required]
        public bool Completed { get; set; }
    }
}
