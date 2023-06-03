namespace eAgenda.WinApp.ContactModule
{
    public partial class ListingContactControl : UserControl
    {

        public ListingContactControl()
        {
            InitializeComponent();        
        }

        public void UpdateRegisters(List<Contact> contacts)
        {
            listContact.Items.Clear();

            listContact.Items.AddRange(contacts.ToArray());
        }

        public Contact GetSelectedContact()
        {
            return listContact.SelectedItem as Contact;
        }
    }
}
