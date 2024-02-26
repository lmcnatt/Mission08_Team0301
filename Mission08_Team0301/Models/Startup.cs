using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission08_Team0301.Models
{
    public class Task
    {
        [Key]
        [Required]
        public int TaskId { get; set; }

        [Required]
        public string TaskName { get; set; }

        public string? DueDate { get; set; }

        [Required]
        public int Quadrant { get; set; }

        public string? Category { get; set; }

        [Required]
        public bool Completed { get; set; }
    }
}
