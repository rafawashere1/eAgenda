using System.Reflection.Metadata.Ecma335;

namespace eAgenda.WinApp.TaskModule
{
    public partial class RegisterItemsTaskForm : Form
    {
        public RegisterItemsTaskForm(Task task)
        {
            InitializeComponent();

            this.ConfigureDialog();

            ConfigureForm(task);
        }

        private void ConfigureForm(Task task)
        {
            txtId.Text = task.Id.ToString();
            txtTitle.Text = task.Title.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitleItem.Text))
                return;

            string title = txtTitleItem.Text;

            TaskItem taskItem = new(title);

            txtTitleItem.Text = "";
            txtTitleItem.Focus();

            listItem.Items.Add(taskItem);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listItem.SelectedItem != null)
                listItem.Items.Remove(listItem.SelectedItem);

            txtTitleItem.Text = "";
        }

        public List<TaskItem> GetRegisteredItems()
        {
            return listItem.Items.Cast<TaskItem>().ToList();
        }
    }
}
