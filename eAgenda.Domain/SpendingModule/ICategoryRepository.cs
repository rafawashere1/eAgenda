namespace eAgenda.Domain.SpendingModule
{
    public interface ICategoryRepository
    {
        void Insert(Category category);
        void Edit(int id, Category category);
        void Delete(Category category);
        Category SelectById(int id);
        List<Category> GetAll();
    }
}