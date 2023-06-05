namespace eAgenda.WinApp.SpendingModule
{
    public class CategoryRepository : RAMBaseRepository<Category>
    {
        public CategoryRepository(List<Category> categories) 
        {
            registersList = categories;
        }

    }
}
