using eAgenda.WinApp.ContactModule;
using eAgenda.WinApp.AppointmentModule;
using eAgenda.WinApp.TaskModule;
using Task = eAgenda.WinApp.TaskModule.Task;

namespace eAgenda.WinApp
{
    public partial class MainForm : Form
    {
        private BaseController _controller;
        private readonly ContactRepository _contactRepository = new(new List<Contact>());
        private readonly AppointmentRepository _appointmentRepository = new(new List<Appointment>());
        private readonly TaskRepository _taskRepository = new(new List<Task>());

        private static MainForm _mainForm;
        public MainForm()
        {
            InitializeComponent();

            _mainForm = this;
        }

        public static MainForm Instance
        {
            get
            {
                _mainForm ??= new MainForm();

                return _mainForm;
            }
        }

        private void contactsMenuItem_Click(object sender, EventArgs e)
        {
            _controller = new ContactController(_contactRepository);

            ConfigureMainForm(_controller);
        }

        private void appointmentMenuItem_Click(object sender, EventArgs e)
        {
            _controller = new AppointmentController(_appointmentRepository, _contactRepository);

            ConfigureMainForm(_controller);
        }

        private void tasksMenuItem_Click(object sender, EventArgs e)
        {
            _controller = new TaskController(_taskRepository);

            ConfigureMainForm(_controller);
        }

        private void ConfigureMainForm(BaseController controllerBase)
        {
            lblTypeRegistration.Text = controllerBase.GetTypeRegistration();

            SetToolTips(controllerBase);

            SetListing(controllerBase);
        }

        public void UpdateFooter(string text)
        {
            lblFooter.Text = text;
        }

        private void SetListing(BaseController controllerBase)
        {
            UserControl listing = controllerBase.GetListing();

            listing.Dock = DockStyle.Fill;

            panelRegisters.Controls.Clear();

            panelRegisters.Controls.Add(listing);
        }

        private void SetToolTips(BaseController controllerBase)
        {
            btnAdd.ToolTipText = controllerBase.ToolTipAdd;
            btnEdit.ToolTipText = controllerBase.ToolTipEdit;
            btnDelete.ToolTipText = controllerBase.ToolTipDelete;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _controller.Insert();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _controller.Edit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _controller.Delete();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            _controller.Filter();
        }
    }
}