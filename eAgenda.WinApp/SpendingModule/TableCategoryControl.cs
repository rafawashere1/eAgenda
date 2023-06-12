using eAgenda.Domain.SpendingModule;

namespace eAgenda.WinApp.SpendingModule
{
    public partial class TableCategoryControl : UserControl
    {
        public TableCategoryControl()
        {
            InitializeComponent();

            grid.ConfigureGridStriped();
            grid.ConfigureGridReadOnly();

            ConfigureColumns();

            grid.Columns["id"].Width = 25;
        }

        private void ConfigureColumns()
        {
            DataGridViewTextBoxColumn id = new();
            id.Name = "Id";
            id.HeaderText = "ID";

            DataGridViewTextBoxColumn title = new();
            title.Name = "Titulo";
            title.HeaderText = "Título";

            grid.Columns.Add(id);
            grid.Columns.Add(title);
        }
        public void UpdateCategories(List<Category> categories)
        {
            grid.Rows.Clear();

            foreach (Category category in categories)
            {
                grid.Rows.Add(category.Id, category.Title);
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
