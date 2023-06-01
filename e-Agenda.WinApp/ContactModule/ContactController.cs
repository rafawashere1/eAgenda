using eAgenda.WinApp.AppointmentModule;

namespace eAgenda.WinApp.ContactModule
{
    public class ContactController : BaseController
    {
        private readonly ContactRepository _contactRepository;
        private ListingContactControl _listingContact;

        public ContactController(ContactRepository contactRepository)
        {
            this._contactRepository = contactRepository;
        }

        public override string ToolTipAdd => "Inserir novo contato";

        public override string ToolTipEdit => "Editar contato existente";

        public override string ToolTipDelete => "Excluir contato existente";

        public override void Insert()
        {
            ContactForm contactForm = new();

            DialogResult dialogResult = contactForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                Contact contact = contactForm.GetContact();

                _contactRepository.Insert(contact);
            }

            LoadContacts();
        }

        public override void Edit()
        {    
            Contact selectedContact = _listingContact.GetSelectedContact();

            if (selectedContact == null)
            {
                MessageBox.Show($"Selecione um contato primeiro!",
                    "Edição de Contatos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            ContactForm contactForm = new();
            contactForm.ConfigureForm(selectedContact);

            DialogResult dialogResult = contactForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                Contact updatedContact = contactForm.GetContact();

                _contactRepository.Edit(updatedContact.Id, updatedContact);

                LoadContacts();
            }
        }

        public override void Delete()
        {
            Contact selectedContact = _listingContact.GetSelectedContact();

            if (selectedContact == null)
            {
                MessageBox.Show($"Selecione um contato primeiro!",
                    "Exclusão de Contatos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult dialogResult = MessageBox.Show($"Deseja excluir o contato {selectedContact.Name}?",
                "Exclusão de Contatos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.OK)
                _contactRepository.Delete(selectedContact);

            LoadContacts();
        }

        private void LoadContacts()
        {
            List<Contact> contacts = _contactRepository.SelectAll();

            _listingContact.UpdateRegisters(contacts);

            MainForm.Instance.UpdateFooter($"Visualizando {contacts.Count} contato(s).");
        }

        public override UserControl GetListing()
        {
            _listingContact ??= new ListingContactControl();

            LoadContacts();

            return _listingContact;
        }

        public override string GetTypeRegistration()
        {
            return "Cadastro de Contatos";
        }
    }
}
