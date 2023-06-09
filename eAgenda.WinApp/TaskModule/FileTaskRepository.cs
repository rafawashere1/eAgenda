using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;

namespace eAgenda.WinApp.TaskModule
{
    public class FileTaskRepository : ITaskRepository
    {
        private int _counter;

        private List<Task> _tasks = new();

        private const string TASK_FILE_NAME = "TaskModule/Tasks.json";

        public FileTaskRepository()
        {
            if (File.Exists(TASK_FILE_NAME))
                LoadTasksFromJsonFile();
        }

        public void Insert(Task task)
        {
            _counter++;

            task.Id = _counter;

            _tasks.Add(task);
            
            SendTasksToJsonFile();
        }

        public void Edit(int id, Task task)
        {
            SelectById(id).UpdateInfos(task);

            SendTasksToJsonFile();
        }

        public void Delete(Task task)
        {
            _tasks.Remove(task);
            
            SendTasksToJsonFile();
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

        private void SendTasksToBinaryFile()
        {
            BinaryFormatter serializer = new();

            MemoryStream taskStream = new();

            serializer.Serialize(taskStream, _tasks);

            File.WriteAllBytes(TASK_FILE_NAME, taskStream.ToArray());
        }

        private void LoadTasksFromBinaryFile()
        {
            BinaryFormatter serializer = new();

            MemoryStream taskStream = new(File.ReadAllBytes(TASK_FILE_NAME));

            _tasks = serializer.Deserialize(taskStream) as List<Task>;

            UpdateCounter();
        }

        private void SendTasksToJsonFile()
        {
            File.WriteAllText(TASK_FILE_NAME, JsonSerializer.Serialize(_tasks));
        }

        private void LoadTasksFromJsonFile()
        {
            _tasks = JsonSerializer.Deserialize<List<Task>>(File.ReadAllText(TASK_FILE_NAME));
        }

        private void SendTasksToXmlFile()
        {
            XmlSerializer serializer = new(typeof(List<Task>));

            MemoryStream taskStream = new();

            serializer.Serialize(taskStream, _tasks);

            File.WriteAllBytes(TASK_FILE_NAME, taskStream.ToArray());
        }

        private void LoadTasksFromXmlFile()
        {
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
