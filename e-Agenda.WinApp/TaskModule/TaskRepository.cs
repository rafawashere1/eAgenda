namespace e_Agenda.WinApp.TasksModule
{
    public class TaskRepository : BaseRepository<Task>
    {
        public TaskRepository(List<Task> tasks)
        {
            registersList = tasks;
        }
    }
}
