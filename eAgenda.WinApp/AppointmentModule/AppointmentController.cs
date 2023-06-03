﻿using eAgenda.WinApp.ContactModule;

namespace eAgenda.WinApp.AppointmentModule
{
    public class AppointmentController : BaseController
    {
        private readonly AppointmentRepository _appointmentRepository;
        private readonly ContactRepository _contactRepository;
        private ListingAppointmentControl _listingAppointment;

        public AppointmentController(AppointmentRepository appointmentRepository, ContactRepository contactRepository)
        {
            this._appointmentRepository = appointmentRepository;
            _contactRepository = contactRepository;

        }
        public override string ToolTipAdd => "Inserir novo compromisso";

        public override string ToolTipEdit => "Editar compromisso existente";

        public override string ToolTipDelete => "Excluir compromisso existente";

        public override void Insert()
        {
            List<Contact> contacts = _contactRepository.SelectAll();

            AppointmentForm appointmentForm = new(contacts);

            DialogResult dialogResult = appointmentForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                Appointment appointment = appointmentForm.GetAppointment();

                _appointmentRepository.Insert(appointment);

                LoadAppointments();
            }
        }

        public override void Edit()
        {
            Appointment selectedAppointment = _listingAppointment.GetSelectedAppointment();

            if (selectedAppointment == null)
            {
                MessageBox.Show($"Selecione um compromisso primeiro",
                    "Edição de compromisso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            List<Contact> contacts = _contactRepository.SelectAll();

            AppointmentForm appointmentForm = new(contacts);

            appointmentForm.ConfigureForm(selectedAppointment);

            DialogResult dialogResult = appointmentForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                Appointment appointment = appointmentForm.GetAppointment();

                _appointmentRepository.Edit(appointment.Id, appointment); 
                
                LoadAppointments();
            }
        }

        public override void Delete()
        {
            Appointment selectedAppointment = _listingAppointment.GetSelectedAppointment();

            if (selectedAppointment == null)
            {
                MessageBox.Show($"Selecione um compromisso primeiro",
                    "Exclusão de compromisso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult dialogResult = MessageBox.Show($"Deseja excluir o compromisso {selectedAppointment.Subject}?",
                "Exclusão de Compromissos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.OK)
                _appointmentRepository.Delete(selectedAppointment);

            LoadAppointments();
        }

        public override void Filter()
        {
            FilterAppointmentForm filterForm = new();

            DialogResult dialogResult = filterForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                StatusAppointmentEnum status = filterForm.GetStatus();
                List<Appointment> appointments = null;

                if (status == StatusAppointmentEnum.All)
                {
                    appointments = _appointmentRepository.SelectAll();
                }

                else if (status == StatusAppointmentEnum.Pasts)
                {
                    appointments = _appointmentRepository.SelectPastAppointments(DateTime.Now);                 
                }
                else if (status == StatusAppointmentEnum.Futures)
                {
                    DateTime startTime = filterForm.GetStartTime();
                    DateTime endTime = filterForm.GetEndTime();

                    appointments = _appointmentRepository.SelectFutureAppointments(startTime, endTime);
                }

                LoadAppointments(appointments);

                MainForm.Instance.UpdateFooter($"Visualizando {appointments.Count} compromisso(s).");
            }
        }

        public override UserControl GetListing()
        {
            _listingAppointment ??= new ListingAppointmentControl();

            LoadAppointments();

            return _listingAppointment;
        }

        public override string GetTypeRegistration() 
        {
            return "Cadastro de Compromissos";
        }

        private void LoadAppointments()
        {
            List<Appointment> appointments = _appointmentRepository.SelectAll();

            _listingAppointment.UpdateRegisters(appointments);

            MainForm.Instance.UpdateFooter($"Visualizando {appointments.Count} compromisso(s).");
        }

        private void LoadAppointments(List<Appointment> appointments)
        {
            _listingAppointment.UpdateRegisters(appointments);
        }
    }
}