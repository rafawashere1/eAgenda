namespace eAgenda.WinApp.TaskModule
{
    public class FileTaskRepository : FileBaseRepository<Task>, ITaskRepository
    {
        public FileTaskRepository(DataContext dataContext) : base(dataContext)
        {

        }

        public List<Task>? SelectMarkeds()
        {
            return GetRegisters().Where(x => x.CompletionPercentage == 100).ToList();
        }

        public List<Task>? SelectUnmarkeds()
        {
            return GetRegisters().Where(x => x.CompletionPercentage < 100).ToList();
        }

        public List<Task>? SelectAllOrdenedByPriority()
        {
            return GetRegisters().OrderByDescending(x => x.Priority).ToList();
        }

        protected override List<Task> GetRegisters()
        {
            return DataContext.Tasks;
        }
    }
}
