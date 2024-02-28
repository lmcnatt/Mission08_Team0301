using Mission08_Team0301.Models;

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

        List<Task> ITaskRepository.Tasks { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
