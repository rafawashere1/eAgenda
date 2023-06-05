namespace eAgenda.WinApp.ContactModule
{
    public class ContactRepository : RAMBaseRepository<Contact>
    {
        public ContactRepository(List<Contact> contacts)
        {
            registersList = contacts;
        }
    }
}
