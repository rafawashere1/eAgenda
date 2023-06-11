namespace eAgenda.WinApp.AppointmentModule
{
    public class FileAppointmentRepository : FileBaseRepository<Appointment>, IAppointmentRepository
    {
        public FileAppointmentRepository(DataContext dataContext) : base(dataContext)
        {

        }

        public List<Appointment>? SelectPastAppointments(DateTime now)
        {
            return GetAll().Where(x => x.Date.Date < now.Date).ToList();
        }

        public List<Appointment>? SelectFutureAppointments(DateTime startTime, DateTime endTime)
        {
            return GetAll()
                .Where(x => x.Date > startTime)
                .Where(x => x.Date < endTime)
                .ToList();
        }

        protected override List<Appointment> GetRegisters()
        {
            return DataContext.Appointments;
        }
    }
}