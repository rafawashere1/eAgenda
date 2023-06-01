namespace e_Agenda.WinApp.AppointmentModule
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

            foreach (Appointment item in appointments)
            {
                listAppointments.Items.Add(item);
            }
        }

        public Appointment GetSelectedAppointment()
        {
            return listAppointments.SelectedItem as Appointment;
        }
    }
}
