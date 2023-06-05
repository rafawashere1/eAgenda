using eAgenda.WinApp.ContactModule;

namespace eAgenda.WinApp.AppointmentModule
{
    public partial class AppointmentForm : Form
    {
        public AppointmentForm(List<Contact> contacts)
        {
            InitializeComponent();

            this.ConfigureDialog();

            LoadContacts(contacts);
        }

        public Appointment GetAppointment()
        {
            int id = Convert.ToInt32(txtId.Text);

            string subject = txtSubject.Text;

            DateTime date = dtpDate.Value;

            TimeSpan startTime = dtpStart.Value.TimeOfDay;

            TimeSpan endTime = dtpEnd.Value.TimeOfDay;

            Contact contact = cmbContact.SelectedItem as Contact;

            TypeAppointment type = rdbOnline.Checked ? TypeAppointment.Online : TypeAppointment.InPerson;

            string adress;

            if (rdbOnline.Checked)
                adress = txtOnline.Text;
            else
                adress = txtInPerson.Text;

            Appointment appointment = new(subject, date, startTime, endTime, contact, adress, type);

            if (id > 0)
                appointment.Id = id;

            return appointment;
        }

        public void ConfigureForm(Appointment selectedAppointment)
        {
            txtId.Text = selectedAppointment.Id.ToString();
            txtSubject.Text = selectedAppointment.Subject;
            dtpDate.Value = selectedAppointment.Date;
            dtpStart.Value = DateTime.Now.Date.Add(selectedAppointment.StartTime);
            dtpEnd.Value = DateTime.Now.Date.Add(selectedAppointment.EndTime);

            if (selectedAppointment.Contact != null)
            {
                ckbSelectContact.Checked = true;
                cmbContact.SelectedItem = selectedAppointment.Contact;
            }

            if (selectedAppointment.TypeAppointment == TypeAppointment.InPerson)
            {
                rdbInPerson.Checked = true;
                txtInPerson.Text = selectedAppointment.InPersonAdress;
            }
            else
            {
                rdbOnline.Checked = true;
                txtOnline.Text = selectedAppointment.OnlineAdress;
            }
        }

        private void LoadContacts(List<Contact> contacts)
        {
            foreach (Contact contact in contacts)
            {
                cmbContact.Items.Add(contact);
            }
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            Appointment appointment = GetAppointment();

            List<string> errors = appointment.Validate();

            if (errors.Count > 0)
            {
                MainForm.Instance.UpdateFooter(errors[0]);

                DialogResult = DialogResult.None;
            }
        }

        private void rdbInPerson_CheckedChanged(object sender, EventArgs e)
        {
            txtInPerson.Enabled = true;
            txtOnline.Enabled = false;
            txtOnline.Text = "";
        }

        private void rdbOnline_CheckedChanged(object sender, EventArgs e)
        {
            txtOnline.Enabled = true;
            txtInPerson.Enabled = false;
            txtInPerson.Text = "";
        }

        private void ckbSelectContact_CheckedChanged(object sender, EventArgs e)
        {
            cmbContact.Enabled = !cmbContact.Enabled;
            cmbContact.SelectedIndex = -1;
        }
    }
}
