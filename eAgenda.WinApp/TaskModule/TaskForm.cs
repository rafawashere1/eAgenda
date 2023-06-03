﻿namespace eAgenda.WinApp.TaskModule
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

            PriorityTaskEnum priority = (PriorityTaskEnum)cmbPriority.SelectedItem;

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
            PriorityTaskEnum[] priorities = Enum.GetValues<PriorityTaskEnum>();

            foreach (PriorityTaskEnum priorityEnum in priorities)
            {
                cmbPriority.Items.Add(priorityEnum);
            }
        }
    }
}