namespace e_Agenda.WinApp.ContactModule
{
    public class ContactRepository : BaseRepository<Contact>
    {
        public ContactRepository(List<Contact> contacts)
        {
            registersList = contacts;
        }
    }
}
