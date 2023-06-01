namespace e_Agenda.WinApp.TasksModule
{
    public class Task : BaseEntity<Task>
    {
        public int id;
        public string title;
        public string priority;

        public Task(int id, string title, string priority)
        {
            this.id = id;
            this.title = title;
            this.priority = priority;
        }

        public override string ToString()
        {
            return $"Id: {id}, título: {title}, prioridade: {priority}";
        }

        public override void UpdateInfos(Task updatedRegister)
        {
            throw new NotImplementedException();
        }

        public override List<string> Validate()
        {
            throw new NotImplementedException();
        }
    }
}
