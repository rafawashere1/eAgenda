namespace eAgenda.Domain.TaskModule
{
    public interface ITaskRepository
    {
        void Insert(Task task);
        void Edit(int id, Task task);
        void Delete(Task task);
        Task SelectById(int id);
        List<Task>? SelectMarkeds();
        List<Task>? SelectUnmarkeds();
        List<Task>? SelectAllOrdenedByPriority();
    }
}
