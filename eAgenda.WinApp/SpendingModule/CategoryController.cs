using eAgenda.Domain.SpendingModule;

namespace eAgenda.WinApp.SpendingModule
{
    public class CategoryController : BaseController
    {
        private readonly ICategoryRepository _categoryRepository;
        private TableCategoryControl _tableCategory;

        public override string ToolTipInsert => "Inserir nova categoria";

        public override string ToolTipEdit => "Editar categoria existente";

        public override string ToolTipDelete => "Excluir categoria existente";

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public override void Insert()
        {
            CategoryForm categoryForm = new();
            DialogResult dialogResult = categoryForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                Category category = categoryForm.GetCategory();
                _categoryRepository.Insert(category);
            }

            LoadCategories();
        }

        public override void Edit()
        {
            Category selectedCategory = GetSelectedCategory();

            if (selectedCategory == null)
            {
                MessageBox.Show($"Selecione uma categoria primeiro!",
                    "Edição de Categorias",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            CategoryForm categoryForm = new();
            categoryForm.ConfigureForm(selectedCategory);

            DialogResult dialogResult = categoryForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                Category updatedCategory = categoryForm.GetCategory();

                _categoryRepository.Edit(updatedCategory.Id, updatedCategory);
            }

            LoadCategories();
        }

        public override void Delete()
        {
            Category selectedCategory = GetSelectedCategory();

            if (selectedCategory == null)
            {
                MessageBox.Show($"Selecione uma categoria primeiro!",
                    "Exclusão de Categorias",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult dialogResult = MessageBox.Show($"Deseja excluir a categoria {selectedCategory.Title}?",
                    "Exclusão de Categorias", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.OK)
                _categoryRepository.Delete(selectedCategory);

            LoadCategories();
        }

        public override UserControl GetListing()
        {
           _tableCategory = new TableCategoryControl();

            LoadCategories();

            return _tableCategory;
        }

        public override string GetTypeRegistration()
        {
            return "Cadastro de Categorias";
        }

        private Category GetSelectedCategory()
        {
            int id = _tableCategory.GetSelectedId();

            return _categoryRepository.SelectById(id);
        }

        private void LoadCategories()
        {
            List<Category> categories = _categoryRepository.GetAll();
            _tableCategory.UpdateCategories(categories);

            MainForm.Instance.UpdateFooter($"Visualizando {categories.Count} categoria(s)");
        }
    }
}
