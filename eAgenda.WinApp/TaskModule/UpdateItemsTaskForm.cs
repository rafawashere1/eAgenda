namespace eAgenda.WinApp.TaskModule
{
    public partial class UpdateItemsTaskForm : Form
    {
        public UpdateItemsTaskForm(Task task)
        {
            InitializeComponent();

            this.ConfigureDialog();

            ConfigureForm(task);
        }

        private void ConfigureForm(Task task)
        {
            txtId.Text = task.Id.ToString();
            txtTitle.Text = task.Title.ToString();

            int i = 0;
            foreach (TaskItem item in task.Items)
            {
                checkedListItem.Items.Add(item);

                if (item.Concluded)
                    checkedListItem.SetItemChecked(i, true);

                i++;
            }
        }

        public List<TaskItem> GetMarkedItems()
        {
            return checkedListItem.CheckedItems.Cast<TaskItem>().ToList();
        }

        public List<TaskItem> GetUnmarkedItems()
        {
            return checkedListItem.Items.Cast<TaskItem>().Except(GetMarkedItems()).ToList();
        }
    }
}
