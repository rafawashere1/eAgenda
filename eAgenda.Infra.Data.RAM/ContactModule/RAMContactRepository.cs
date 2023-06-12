using eAgenda.Domain.ContactModule;

namespace eAgenda.Infra.Data.RAM.ContactModule
{
    public class ContactRepository : RAMBaseRepository<Contact>
    {
        public ContactRepository(List<Contact> contacts)
        {
            registersList = contacts;
        }
    }
}
