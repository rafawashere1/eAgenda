namespace eAgenda.WinApp.TaskModule
{
    public interface ITaskRepository
    {
        void Insert(Task task);
        void Edit(int id, Task task);
        void Delete(int id);
        Task SelectById(int v);
        List<Task>? SelectMarkeds();
        List<Task>? SelectUnmarkeds();
        List<Task>? SelectAllOrdenedByPriority();
    }
}
