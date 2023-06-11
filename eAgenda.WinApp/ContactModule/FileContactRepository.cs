namespace eAgenda.WinApp.ContactModule
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