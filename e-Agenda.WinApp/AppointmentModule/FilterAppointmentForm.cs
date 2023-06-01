namespace e_Agenda.WinApp.AppointmentModule
{
    public partial class FilterAppointmentForm : Form
    {
        public FilterAppointmentForm()
        {
            InitializeComponent();
        }

        public AppointmentStatusEnum GetStatus()
        {
            if (rdbFutures.Checked)
            {
                return AppointmentStatusEnum.Futures;
            }
            else if (rdbPasts.Checked)
            {
                return AppointmentStatusEnum.Pasts;
            }
            else
            {
                return AppointmentStatusEnum.All;
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
