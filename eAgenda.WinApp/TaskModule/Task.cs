namespace eAgenda.WinApp.TaskModule
{
    public class Task : BaseEntity<Task>
    {
        public string Title { get; set; }
        public PriorityTaskEnum Priority { get; set; }
        public DateTime CreationDate { get; set; }
        public List<TaskItem> Items { get; set; }
        public decimal CompletionPercentage { get; set; }

        public Task(string title, PriorityTaskEnum priority, DateTime creationDate)
        {
            Title = title;
            Priority = priority;
            CreationDate = creationDate;
            Items = new List<TaskItem>();

            CalculateCompletionPercentage();
        }

        public override string ToString()
        {
            return $"Id: {Id}, título: {Title}, prioridade: {Priority}, percentual concluído {CompletionPercentage}%";
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

        public void AddItem(TaskItem item)
        {
            Items.Add(item);

            CalculateCompletionPercentage();
        }

        public void MarkItem(TaskItem item)
        {
            TaskItem selectedItem = Items.FirstOrDefault(x => x.Equals(item));

            selectedItem.Mark();

            CalculateCompletionPercentage();
        }

        public void UnmarkItem(TaskItem item)
        {
            TaskItem selectedItem = Items.FirstOrDefault(x => x.Equals(item));

            selectedItem.Unmark();

            CalculateCompletionPercentage();
        }

        private void CalculateCompletionPercentage()
        {
            decimal concludedQuantity = Items.Count(x => x.Concluded);

            decimal itensQuantity = Items.Count();

            if (itensQuantity == 0)
                CompletionPercentage = 100;
            else
                CompletionPercentage = Math.Round((concludedQuantity / itensQuantity) * 100, 2);
        }
    }
}
