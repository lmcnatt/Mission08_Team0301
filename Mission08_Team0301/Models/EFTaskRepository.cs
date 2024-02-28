using Mission6_Sentz.Models;

namespace Mission08_Team0301.Models
{
    public class EFTaskRepository : ITaskRepository
    {
        private AddTaskContext _context;

        public EFTaskRepository(AddTaskContext temp)
        {
            _context = temp;
        }
        public List<Task> Tasks => _context.Tasks.ToList();
    }
}
