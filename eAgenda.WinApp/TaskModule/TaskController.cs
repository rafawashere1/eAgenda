namespace eAgenda.WinApp.TaskModule
{
    public class TaskController : BaseController
    {
        private readonly ITaskRepository _taskRepository;
        private TableTaskControl _tableTask;

        public TaskController(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public override string ToolTipInsert => "Inserir nova tarefa";
        public override string ToolTipEdit => "Editar tarefa existente";
        public override string ToolTipDelete => "Excluir tarefa existente";
        public override string ToolTipFilter => "Filtrar tarefas";
        public override string ToolTipAddItems => "Adicionar itens na tarefa";
        public override string ToolTipConcludeItems => "Concluir itens da tarefa";

        public override bool IsFilterEnabled => true;
        public override bool IsAddItemsEnabled => true;
        public override bool IsConcludeItemsEnabled => true;

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
            Task selectedTask = GetSelectedTask();

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
            Task selectedTask = GetSelectedTask();

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

        public override void Filter()
        {
            FilterTaskForm filterForm = new();

            DialogResult dialogResult = filterForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                List<Task> tasks = null;

                StatusTask status = filterForm.GetFilterTask();

                switch (status)
                {
                    case StatusTask.Marked: tasks = _taskRepository.SelectMarkeds();
                        break;
                    case StatusTask.Unmarked: tasks = _taskRepository.SelectUnmarkeds();
                        break;
                    default: tasks = _taskRepository.SelectAllOrdenedByPriority();
                        break;
                }

                LoadTasks(tasks);
            }
        }

        public override void Add()
        {
            Task selectedTask = GetSelectedTask();

            if (selectedTask == null)
            {
                MessageBox.Show($"Selecione uma tarefa primeiro!",
                    "Itens da Tarefa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            RegisterItemsTaskForm registerItemsTask = new(selectedTask);

            DialogResult dialogResult = registerItemsTask.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                List<TaskItem> itemsToAdd = registerItemsTask.GetRegisteredItems();

                foreach (TaskItem item in itemsToAdd) 
                {
                    selectedTask.AddItem(item);
                }

                _taskRepository.Edit(selectedTask.Id, selectedTask);

                LoadTasks();
            }
        }

        public override void ConcludeItems()
        {
            Task selectedTask = GetSelectedTask();

            if (selectedTask == null)
            {
                MessageBox.Show($"Selecione uma tarefa primeiro!",
                    "Itens da Tarefa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            UpdateItemsTaskForm updateItemsTask = new(selectedTask);

            DialogResult dialogResult = updateItemsTask.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                List<TaskItem> markedItems = updateItemsTask.GetMarkedItems();

                List<TaskItem> unmarkedItems = updateItemsTask.GetUnmarkedItems();

                foreach (TaskItem item in markedItems)
                {
                    selectedTask.MarkItem(item);
                }

                foreach (TaskItem item in unmarkedItems)
                {
                    selectedTask.UnmarkItem(item);
                }

                _taskRepository.Edit(selectedTask.Id, selectedTask);

                LoadTasks();
            }
        }

        public override UserControl GetListing()
        {
            _tableTask ??= new TableTaskControl();

            LoadTasks();

            return _tableTask;
        }

        public override string GetTypeRegistration()
        {
            return "Cadastro de Tarefas";
        }

        private Task GetSelectedTask()
        {
            return _taskRepository.SelectById(_tableTask.GetSelectedId());
        }

        private void LoadTasks()
        {
            List<Task> tasks = _taskRepository.SelectAllOrdenedByPriority();

            _tableTask.UpdateRegisters(tasks);

            MainForm.Instance.UpdateFooter($"Visualizando {tasks.Count} tarefa(s)");
        }

        private void LoadTasks(List<Task> tasks)
        {
            _tableTask.UpdateRegisters(tasks);

            MainForm.Instance.UpdateFooter($"Visualizando {tasks.Count} tarefa(s)");
        }
    }
}
