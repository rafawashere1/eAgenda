using eAgenda.Domain.TaskModule;
using Task = eAgenda.Domain.TaskModule.Task;
using Utils = eAgenda.WinApp.Shared.Utils;

namespace eAgenda.WinApp.TaskModule
{
    public partial class TaskForm : Form
    {
        public TaskForm(bool isEdit)
        {
            InitializeComponent();

            this.ConfigureDialog();

            LoadPriorities();

            if (isEdit)
                dtpCreationDate.Enabled = false;
        }

        public Task GetTask()
        {
            int id = Convert.ToInt32(txtId.Text);

            string title = txtTitle.Text;

            PriorityTask priority = Utils.GetEnumValueFromDescription<PriorityTask>(cmbPriority.SelectedItem.ToString());

            DateTime creationDate = dtpCreationDate.Value;

            Task task = new(title, priority, creationDate);

            if (id > 0)
                task.Id = id;

            return task;
        }

        public void ConfigureForm(Task selectedTask)
        {
            txtId.Text = selectedTask.Id.ToString();
            txtTitle.Text = selectedTask.Title;
            cmbPriority.SelectedItem = selectedTask.Priority;
            dtpCreationDate.Value = selectedTask.CreationDate;
        }

        private void LoadPriorities()
        {
            PriorityTask[] priorities = Enum.GetValues<PriorityTask>();

            foreach (PriorityTask priorityEnum in priorities)
            {
                cmbPriority.Items.Add(priorityEnum.GetDescription());
            }
        }
    }
}
