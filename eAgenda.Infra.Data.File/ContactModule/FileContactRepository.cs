using eAgenda.Domain.ContactModule;

namespace eAgenda.Infra.Data.File.ContactModule
{
    public class FileContactRepository : FileBaseRepository<Contact>, IContactRepository
    {
        public FileContactRepository(DataContext dataContext) : base(dataContext)
        {
        }

        protected override List<Contact> GetRegisters()
        {
            return DataContext.Contacts;
        }
    }
}