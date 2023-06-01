namespace eAgenda.WinApp.TaskModule
{
    public class TaskController : BaseController
    {
        private readonly TaskRepository _taskRepository;
        private ListingTaskControl _listingTask;

        public TaskController(TaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public override string ToolTipAdd => "Inserir nova tarefa";

        public override string ToolTipEdit => "Editar tarefa existente";

        public override string ToolTipDelete => "Excluir tarefa existente";

        public override void Insert()
        {
            TaskForm taskForm = new(isEdit: false);

            DialogResult dialogResult = taskForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                Task task = taskForm.GetTask();

                _taskRepository.Insert(task);

                LoadTasks();
            }
        }

        public override void Edit()
        {
            Task selectedTask = _listingTask.GetSelectedTask();

            if (selectedTask == null)
            {
                MessageBox.Show($"Selecione uma tarefa primeiro!",
                    "Edição de Tarefas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TaskForm taskForm = new(isEdit: true);

            taskForm.ConfigureForm(selectedTask);

            DialogResult dialogResult = taskForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                Task task = taskForm.GetTask();

                _taskRepository.Edit(task.Id, task);

                LoadTasks();
            }
        }

        public override void Delete()
        {
            Task selectedTask = _listingTask.GetSelectedTask();

            if (selectedTask == null)
            {
                MessageBox.Show($"Selecione uma tarefa primeiro!",
                    "Exclusão de Tarefas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult dialogResult = MessageBox.Show($"Deseja excluir a tarefa {selectedTask.Title}?",
                    "Exclusão de Tarefas", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);

            if (dialogResult == DialogResult.OK)
                _taskRepository.Delete(selectedTask.Id);

            LoadTasks();
        }

        public override UserControl GetListing()
        {
            _listingTask ??= new ListingTaskControl();

            LoadTasks();

            return _listingTask;
        }

        public override string GetTypeRegistration()
        {
            return "Cadastro de Tarefas";
        }

        private void LoadTasks()
        {
            List<Task> tasks = _taskRepository.SelectAll();

            _listingTask.UpdateRegisters(tasks);

            MainForm.Instance.UpdateFooter($"Visualizando {tasks.Count} tarefa(s)");
        }
    }
}
