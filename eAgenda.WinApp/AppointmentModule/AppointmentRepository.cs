namespace eAgenda.WinApp.AppointmentModule
{
    public class AppointmentRepository : RAMBaseRepository<Appointment>
    {
        public AppointmentRepository(List<Appointment> appointments)
        {
            this.registersList = appointments;
        }

        public List<Appointment> SelectPastAppointments(DateTime now)
        {
            return registersList.Where(x => x.Date.Date < now.Date).ToList();
        }

        public List<Appointment> SelectFutureAppointments(DateTime startTime, DateTime endTime)
        {
            return registersList
                .Where(x => x.Date > startTime)
                .Where(x => x.Date < endTime)              
                .ToList();
        }
    }
}
