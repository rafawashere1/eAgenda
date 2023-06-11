namespace eAgenda.WinApp.SpendingModule
{
    public class FileCategoryRepository : FileBaseRepository<Category>, ICategoryRepository
    {
        public FileCategoryRepository(DataContext dataContext) : base(dataContext)
        {

        }

        protected override List<Category> GetRegisters()
        {
            return DataContext.Categories;
        }
    }
}