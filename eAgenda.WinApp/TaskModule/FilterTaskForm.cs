namespace eAgenda.WinApp.TaskModule
{
    public partial class FilterTaskForm : Form
    {
        public FilterTaskForm()
        {
            InitializeComponent();
        }

        public StatusTaskEnum GetFilterTask()
        {
            if (rdbMarkeds.Checked)
                return StatusTaskEnum.Marked;
            else if (rdbUnmarkeds.Checked)
                return StatusTaskEnum.Unmarked;
            else
                return StatusTaskEnum.All;
        }
    }
}
