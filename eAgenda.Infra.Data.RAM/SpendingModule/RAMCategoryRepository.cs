using eAgenda.Domain.SpendingModule;

namespace eAgenda.Infra.Data.RAM.SpendingModule
{
    public class RAMCategoryRepository : RAMBaseRepository<Category>
    {
        public RAMCategoryRepository(List<Category> categories) 
        {
            registersList = categories;
        }

    }
}
