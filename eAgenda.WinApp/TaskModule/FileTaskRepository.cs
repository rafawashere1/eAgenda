using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace eAgenda.WinApp.TaskModule
{
    public class FileTaskRepository : ITaskRepository
    {
        private int _counter;

        private List<Task> _tasks = new();

        private const string TASK_FILE_NAME = "TaskModule/Tasks.xml";

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

        private void SendTasksToFile()
        {
            //BinaryFormatter serializer = new();

            XmlSerializer serializer = new(typeof(List<Task>));

            MemoryStream taskStream = new();

            serializer.Serialize(taskStream, _tasks);

            File.WriteAllBytes(TASK_FILE_NAME, taskStream.ToArray());
        }

        private void LoadTasksFromFile()
        {
            //BinaryFormatter serializer = new();

            XmlSerializer serializer = new(typeof(List<Task>));

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
