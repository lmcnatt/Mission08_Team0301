using System.ComponentModel.DataAnnotations;

namespace Mission08_Team0301.Models
{
    public class Category
    {
        [Key][Required] public int CategoryId { get; set; }
        [Required] public string CategoryName { get; set; }
    }
}
