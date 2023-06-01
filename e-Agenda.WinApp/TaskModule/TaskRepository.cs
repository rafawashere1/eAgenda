namespace eAgenda.WinApp.TaskModule
{
    public class TaskRepository : BaseRepository<Task>
    {
        public TaskRepository(List<Task> tasks)
        {
            registersList = tasks;
        }
    }
}
