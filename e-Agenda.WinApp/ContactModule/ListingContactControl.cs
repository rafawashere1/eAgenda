namespace e_Agenda.WinApp.ContactModule
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

            foreach (Contact item in contacts)
            {
                listContact.Items.Add(item);
            }
        }

        public Contact GetSelectedContact()
        {
            return listContact.SelectedItem as Contact;
        }
    }
}
