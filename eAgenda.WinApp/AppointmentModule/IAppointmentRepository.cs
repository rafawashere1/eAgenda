namespace eAgenda.WinApp.AppointmentModule
{
    public interface IAppointmentRepository
    {
        void Insert(Appointment appointment);
        void Edit(int id, Appointment appointment);
        void Delete(Appointment appointment);
        Appointment SelectById(int id);
        List<Appointment>? GetAll();
        List<Appointment>? SelectPastAppointments(DateTime now);
        List<Appointment>? SelectFutureAppointments(DateTime startTime, DateTime endTime);
    }
}