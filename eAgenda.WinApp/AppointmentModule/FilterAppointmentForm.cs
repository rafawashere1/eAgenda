namespace eAgenda.WinApp.AppointmentModule
{
    public partial class FilterAppointmentForm : Form
    {
        public FilterAppointmentForm()
        {
            InitializeComponent();
        }

        public StatusAppointmentEnum GetStatus()
        {
            if (rdbFutures.Checked)
            {
                return StatusAppointmentEnum.Futures;
            }
            else if (rdbPasts.Checked)
            {
                return StatusAppointmentEnum.Pasts;
            }
            else
            {
                return StatusAppointmentEnum.All;
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
