using eAgenda.Domain.AppointmentModule;

namespace eAgenda.WinApp.AppointmentModule
{
    public partial class FilterAppointmentForm : Form
    {
        public FilterAppointmentForm()
        {
            InitializeComponent();
        }

        public StatusAppointment GetStatus()
        {
            if (rdbFutures.Checked)
            {
                return StatusAppointment.Futures;
            }
            else if (rdbPasts.Checked)
            {
                return StatusAppointment.Pasts;
            }
            else
            {
                return StatusAppointment.All;
            }
        }

        public DateTime GetStartTime()
        {
            return dtpStartDate.Value;
        }

        public DateTime GetEndTime()
        {
            return dtpEndDate.Value;
        }

        private void rdbFutures_CheckedChanged(object sender, EventArgs e)
        {
            dtpStartDate.Enabled = !dtpStartDate.Enabled;
            dtpEndDate.Enabled = !dtpEndDate.Enabled;
        }
    }
}
