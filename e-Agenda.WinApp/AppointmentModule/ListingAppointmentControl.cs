namespace eAgenda.WinApp.AppointmentModule
{
    public partial class ListingAppointmentControl : UserControl
    {
        public ListingAppointmentControl()
        {
            InitializeComponent();
        }

        public void UpdateRegisters(List<Appointment> appointments)
        {
            listAppointments.Items.Clear();

            listAppointments.Items.AddRange(appointments.ToArray());
        }

        public Appointment GetSelectedAppointment()
        {
            return listAppointments.SelectedItem as Appointment;
        }
    }
}
