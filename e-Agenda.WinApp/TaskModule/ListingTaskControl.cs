namespace e_Agenda.WinApp.TasksModule
{
    public partial class ListingTaskControl : UserControl
    {
        List<Task> tasks = new();

        public ListingTaskControl()
        {
            InitializeComponent();

            tasks.Add(new Task(3, "Rafael", "Academia do Programador"));
            tasks.Add(new Task(4, "Agatha", "Academia do Programador"));

            foreach (Task item in tasks)
            {
                listTask.Items.Add(item);
            }
        }
    }
}
