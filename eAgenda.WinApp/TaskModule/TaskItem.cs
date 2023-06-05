namespace eAgenda.WinApp.TaskModule
{
    [Serializable]
    public class TaskItem
    {
        public string Title { get; set; }
        public bool Concluded { get; set; }

        public TaskItem(string title)
        {
            Title = title;
        }

        public override string ToString()
        {
            return $"{Title}";
        }

        public void Mark()
        {
            Concluded = true;
        }

        public void Unmark()
        {
            Concluded = false;
        }

        public override bool Equals(object? obj)
        {
            return obj is TaskItem item &&
                   Title == item.Title &&
                   Concluded == item.Concluded;
        }
    }
}
