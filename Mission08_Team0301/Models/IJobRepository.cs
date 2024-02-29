namespace Mission08_Team0301.Models
{
    public interface IJobRepository
    {

        List<Job> Jobs { get; }
        public void AddJob(Job job);
        public void CompleteJob(Job job);
        public void EditJob(Job UpdatedJob);
        public void DeleteJob(Job job);
    }
}
