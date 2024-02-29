namespace Mission08_Team0301.Models
{
    public class EFJobRepository : IJobRepository
    {
        private JobContext _context;

        public EFJobRepository(JobContext temp)
        {
            _context = temp;
        }
        public List<Job> Jobs => _context.Jobs.ToList();

        public void AddJob(Job job)
        {
            _context.Add(job);
            _context.SaveChanges();
        }

        public void CompleteJob(Job job)
        {
            job.Completed = true;
            _context.SaveChanges();
        }

        public void EditJob(Job UpdatedJob)
        {
            _context.Update(UpdatedJob);
            _context.SaveChanges();
        }

        public void DeleteJob(Job Job)
        {
            _context.Jobs.Remove(Job);
            _context.SaveChanges();
        }
    }
}
