namespace eAgenda.WinApp.TaskModule
{
    public partial class ListingTaskControl : UserControl
    {
        public ListingTaskControl()
        {
            InitializeComponent();
        }
        public void UpdateRegisters(List<Task> tasks)
        {
            listTask.Items.Clear();

            listTask.Items.AddRange(tasks.ToArray());
        }

        public Task GetSelectedTask()
        {
            return listTask.SelectedItem as Task;
        }
    }
}
