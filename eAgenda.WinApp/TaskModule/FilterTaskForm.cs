namespace eAgenda.WinApp.TaskModule
{
    public partial class FilterTaskForm : Form
    {
        public FilterTaskForm()
        {
            InitializeComponent();
        }

        public StatusTask GetFilterTask()
        {
            if (rdbMarkeds.Checked)
                return StatusTask.Marked;
            else if (rdbUnmarkeds.Checked)
                return StatusTask.Unmarked;
            else
                return StatusTask.All;
        }
    }
}
