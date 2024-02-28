using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Mission08_Team0301.Models
{
    public class AddTaskContext : DbContext // Liaison from the app to the database
    {
        public AddTaskContext(DbContextOptions<AddTaskContext> options) : base(options) // Constructor
        {
        }

        public DbSet<Task> Tasks { get; set; }
    }
}
