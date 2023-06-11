namespace eAgenda.WinApp.ContactModule
{
    public interface IContactRepository
    {
        void Insert(Contact contact);
        void Edit(int id, Contact contact);
        void Delete(Contact contact);
        Contact SelectById(int id);
        List<Contact> GetAll();
    }
}