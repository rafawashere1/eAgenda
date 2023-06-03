namespace eAgenda.WinApp.TaskModule
{
    public class TaskRepository : BaseRepository<Task>
    {
        public TaskRepository(List<Task> tasks)
        {
            registersList = tasks;
        }

        public List<Task>? SelectMarkeds()
        {
            return registersList.Where(x => x.CompletionPercentage == 100).OrderByDescending(x => x.Priority).ToList();
        }

        public List<Task>? SelectUnmarkeds()
        {
            return registersList.Where(x => x.CompletionPercentage < 100).OrderByDescending(x => x.Priority).ToList();
        }

        public List<Task>? SelectAllOrdenedByPriority()
        {
            return registersList.OrderByDescending(x => x.Priority).ToList();
        }
    }
}
