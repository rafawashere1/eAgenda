using eAgenda.WinApp.ContactModule;

namespace eAgenda.WinApp.AppointmentModule
{
    public class Appointment : BaseEntity<Appointment>
    {
        public string Subject { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan StartTime { get; set; } 
        public TimeSpan EndTime { get; set; }
        public Contact Contact { get; set; }
        public string InPersonAdress { get; set; }
        public string OnlineAdress { get; set; }
        public TypeAppointmentEnum TypeAppointment { get; set; }

        public Appointment(string subject, DateTime date, TimeSpan startTime, TimeSpan endTime,
            Contact contact, string adress, TypeAppointmentEnum typeAppointment)
        {
            Subject = subject;
            Date = date;
            StartTime = startTime;
            EndTime = endTime;
            Contact = contact;;
            TypeAppointment = typeAppointment;

            if (typeAppointment == TypeAppointmentEnum.Online)
                OnlineAdress = adress;
            else
                InPersonAdress = adress;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Assunto: {Subject}, Data: {Date}";
        }

        public override void UpdateInfos(Appointment updatedRegister)
        {
            Subject = updatedRegister.Subject;
            Date = updatedRegister.Date;
            StartTime = updatedRegister.StartTime;
            EndTime = updatedRegister.EndTime;
            Contact = updatedRegister.Contact;
            TypeAppointment = updatedRegister.TypeAppointment;

            if (updatedRegister.TypeAppointment == TypeAppointmentEnum.Online)
                OnlineAdress = updatedRegister.OnlineAdress;
            else
                InPersonAdress = updatedRegister.InPersonAdress;
        }

        public override List<string> Validate()
        {
            List<string> errors = new();

            TimeSpan timeDifference = EndTime - StartTime;

            if (string.IsNullOrWhiteSpace(Subject))
                errors.Add("O campo 'assunto' é obrigatório");

            if (timeDifference.TotalMinutes < 15)
                errors.Add("A diferença entre o horário de início e o horário de término deve ser de pelo menos 15 minutos");

            if (StartTime >= EndTime)
                errors.Add("Horário de início deve ser menor que o horário final");

            return errors;
        }

        public override bool Equals(object? obj)
        {
            return obj is Appointment appointment &&
                   Id == appointment.Id &&
                   Subject == appointment.Subject &&
                   Date == appointment.Date &&
                   StartTime.Equals(appointment.StartTime) &&
                   EndTime.Equals(appointment.EndTime) &&
                   EqualityComparer<Contact>.Default.Equals(Contact, appointment.Contact) &&
                   InPersonAdress == appointment.InPersonAdress &&
                   OnlineAdress == appointment.OnlineAdress &&
                   TypeAppointment == appointment.TypeAppointment;
        }
    }
}
