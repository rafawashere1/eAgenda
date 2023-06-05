namespace eAgenda.WinApp.TaskModule
{
    public class FileTaskRepository : ITaskRepository
    {
        public void Insert(Task task)
        {
            throw new NotImplementedException();
        }
        public void Edit(int id, Task task)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task SelectById(int v)
        {
            throw new NotImplementedException();
        }

        public List<Task>? SelectMarkeds()
        {
            throw new NotImplementedException();
        }

        public List<Task>? SelectUnmarkeds()
        {
            throw new NotImplementedException();
        }

        public List<Task>? SelectAllOrdenedByPriority()
        {
            throw new NotImplementedException();
        }
    }
}
