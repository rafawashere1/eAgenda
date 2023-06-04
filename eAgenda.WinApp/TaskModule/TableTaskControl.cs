namespace eAgenda.WinApp.TaskModule
{
    public partial class TableTaskControl : UserControl
    {
        public TableTaskControl()
        {
            InitializeComponent();

            ConfigureColumns();

            grid.ConfigureGridStriped();

            grid.ConfigureGridReadOnly();
        }

        private void ConfigureColumns()
        {
            DataGridViewTextBoxColumn[] columns = new DataGridViewTextBoxColumn[]
                        {
                new()
                {
                    Name = "id",
                    HeaderText = "ID"
                },
                new()
                {
                    Name = "title",
                    HeaderText = "Título"
                },
                new()
                {
                    Name = "priority",
                    HeaderText = "Prioridade"
                },
                new()
                {
                    Name = "completionPercentage",
                    HeaderText = "% Concluído"
                }
                        };

            grid.Columns.AddRange(columns);
        }

        public void UpdateRegisters(List<Task> tasks)
        {
            foreach (Task task in tasks)
            {
                if (task != null)
                {
                    grid.Rows.Add(task.Id, task.Title, task.Priority.GetDescription(), task.CompletionPercentage);
                }
            }
        }

        public int GetSelectedId()
        {
            int id;

            try
            {
                id = Convert.ToInt32(grid.SelectedRows[0].Cells["id"].Value);
            }
            catch
            {
                id = -1;
            }

            return id;
        }
    }
}
