using System.Runtime.Serialization.Formatters.Binary;

namespace eAgenda.WinApp.TaskModule
{
    public class FileTaskRepository : ITaskRepository
    {
        private int _counter;

        private List<Task> _tasks = new();

        private const string TASK_FILE_NAME = "C:\\temp\\tasks\\dados-tasks.bin";

        public FileTaskRepository()
        {
            if (File.Exists(TASK_FILE_NAME))
                LoadTasksFromFile();
        }

        public void Insert(Task task)
        {
            _counter++;

            task.Id = _counter;

            _tasks.Add(task);
            
            SendTasksToFile();
        }

        public void Edit(int id, Task task)
        {
            SelectById(id).UpdateInfos(task);

            SendTasksToFile();
        }

        public void Delete(Task task)
        {
            _tasks.Remove(task);
            
            SendTasksToFile();
        }

        public Task SelectById(int id)
        {
            return _tasks.FirstOrDefault(x => x.Id == id);
        }

        public List<Task>? SelectMarkeds()
        {
            return _tasks.Where(x => x.CompletionPercentage == 100).ToList();
        }

        public List<Task>? SelectUnmarkeds()
        {
            return _tasks.Where(x => x.CompletionPercentage < 100).ToList();
        }

        public List<Task>? SelectAllOrdenedByPriority()
        {
            return _tasks.OrderByDescending(x => x.Priority).ToList();
        }

        private List<Task> SelectAll()
        {
            return _tasks;
        }

        private void SendTasksToFile()
        {
            BinaryFormatter serializer = new();

            MemoryStream taskStream = new();

            serializer.Serialize(taskStream, _tasks);

            File.WriteAllBytes(TASK_FILE_NAME, taskStream.ToArray());
        }

        private void LoadTasksFromFile()
        {
            BinaryFormatter serializer = new();

            MemoryStream taskStream = new(File.ReadAllBytes(TASK_FILE_NAME));

            _tasks = serializer.Deserialize(taskStream) as List<Task>;

            UpdateCounter();
        }

        private void UpdateCounter()
        {
            _counter = _tasks.Max(x => x.Id);
        }
    }
}
