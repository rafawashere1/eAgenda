namespace eAgenda.WinApp.TaskModule
{
    public partial class TableTaskControl : UserControl
    {
        public TableTaskControl()
        {
            InitializeComponent();

            ConfigureColumns();

            ConfigurarGridZebrado();

            ConfigurarGridSomenteLeitura();
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

        public void ConfigurarGridZebrado()
        {
            Font font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);

            DataGridViewCellStyle linhaEscura = new DataGridViewCellStyle
            {
                BackColor = Color.LightGray,
                Font = font,
                ForeColor = Color.Black,
                SelectionBackColor = Color.LightYellow,
                SelectionForeColor = Color.Black
            };

            grid.AlternatingRowsDefaultCellStyle = linhaEscura;

            DataGridViewCellStyle linhaClara = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                Font = font,
                SelectionBackColor = Color.LightYellow,
                SelectionForeColor = Color.Black
            };

            grid.RowsDefaultCellStyle = linhaClara;
        }

        public void ConfigurarGridSomenteLeitura()
        {
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;

            grid.BorderStyle = BorderStyle.None;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            grid.MultiSelect = false;
            grid.ReadOnly = true;

            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AutoGenerateColumns = false;

            grid.AllowUserToResizeRows = false;
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

        public Task GetSelectedTask()
        {
            throw new NotImplementedException();
        }
    }
}
