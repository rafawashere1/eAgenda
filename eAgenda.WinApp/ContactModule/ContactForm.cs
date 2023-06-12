using eAgenda.Domain.ContactModule;

namespace eAgenda.WinApp.ContactModule
{
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();

            this.ConfigureDialog();
        }

        public Contact GetContact()
        {
            int id = Convert.ToInt32(txtId.Text);

            string name = txtName.Text;

            string phone = mtbPhone.Text;

            string email = txtEmail.Text;

            string company = txtCompany.Text;

            string jobTitle = txtJobTitle.Text;

            Contact contact = new(name, phone, email, company, jobTitle);

            if (id > 0)
                contact.Id = id;

            return contact;
        }

        public void ConfigureForm(Contact contact)
        {
            txtId.Text = contact.Id.ToString();

            txtName.Text = contact.Name;

            mtbPhone.Text = contact.Phone;

            txtEmail.Text = contact.Email;

            txtCompany.Text = contact.Company;

            txtJobTitle.Text = contact.JobTitle;
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            Contact contact = GetContact();

            List<string> errors = contact.Validate();

            if (errors.Count > 0)
            {
                MainForm.Instance.UpdateFooter(errors[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
