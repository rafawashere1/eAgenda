namespace eAgenda.WinApp.TaskModule
{
    public class FileTaskRepository : FileBaseRepository<Task>, ITaskRepository
    {

        public FileTaskRepository()
        {
            if (File.Exists(GetFileName()))
                LoadRegistersFromJsonFile();
        }
        public List<Task>? SelectMarkeds()
        {
            return registers.Where(x => x.CompletionPercentage == 100).ToList();
        }

        public List<Task>? SelectUnmarkeds()
        {
            return registers.Where(x => x.CompletionPercentage < 100).ToList();
        }

        public List<Task>? SelectAllOrdenedByPriority()
        {
            return registers.OrderByDescending(x => x.Priority).ToList();
        }

        protected override string GetFileName()
        {
            return "TaskModule/Tasks.json";
        }
    }
}
