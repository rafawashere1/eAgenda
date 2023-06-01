namespace eAgenda.WinApp.TaskModule
{
    public class Task : BaseEntity<Task>
    {
        public string Title { get; set; }
        public TaskPriorityEnum Priority { get; set; }
        public DateTime CreationDate { get; set; }

        public Task(string title, TaskPriorityEnum priority, DateTime creationDate)
        {
            Title = title;
            Priority = priority;
            CreationDate = creationDate;
        }

        public override string ToString()
        {
            return $"Id: {Id}, título: {Title}, prioridade: {Priority}";
        }

        public override void UpdateInfos(Task updatedRegister)
        {
            Id = updatedRegister.Id;
            Title = updatedRegister.Title;
            Priority = updatedRegister.Priority;
        }

        public override List<string> Validate()
        {
            return new List<string>();
        }
    }
}
