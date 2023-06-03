namespace eAgenda.WinApp.ContactModule
{
    public class ContactRepository : BaseRepository<Contact>
    {
        public ContactRepository(List<Contact> contacts)
        {
            registersList = contacts;
        }
    }
}
