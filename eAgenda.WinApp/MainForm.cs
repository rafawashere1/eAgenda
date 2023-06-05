using eAgenda.WinApp.ContactModule;
using eAgenda.WinApp.AppointmentModule;
using eAgenda.WinApp.TaskModule;
using Task = eAgenda.WinApp.TaskModule.Task;
using eAgenda.WinApp.SpendingModule;

namespace eAgenda.WinApp
{
    public partial class MainForm : Form
    {
        private BaseController _controller;
        private readonly ContactRepository _contactRepository = new(new List<Contact>());
        private readonly AppointmentRepository _appointmentRepository = new(new List<Appointment>());
        private readonly ITaskRepository _taskRepository = new FileTaskRepository();
        private readonly CategoryRepository _categoryRepository = new(new List<Category>());

        private static MainForm _mainForm;
        public MainForm()
        {
            InitializeComponent();

            lblTypeRegistration.Text = "";

            lblFooter.Text = "Bem-Vindo à eAgenda!";

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

        private void categoriesMenuItem_Click(object sender, EventArgs e)
        {
            _controller = new CategoryController(_categoryRepository);

            ConfigureMainForm(_controller);
        }

        private void ConfigureMainForm(BaseController controllerBase)
        {
            lblTypeRegistration.Text = controllerBase.GetTypeRegistration();

            ConfigureToolbar(controllerBase);

            SetListing(controllerBase);
        }

        private void ConfigureToolbar(BaseController controllerBase)
        {
            toolbar.Enabled = true;

            SetToolTips(controllerBase);

            SetButtonStatus(controllerBase);
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
            btnInsert.ToolTipText = controllerBase.ToolTipInsert;
            btnEdit.ToolTipText = controllerBase.ToolTipEdit;
            btnDelete.ToolTipText = controllerBase.ToolTipDelete;
            btnFilter.ToolTipText = controllerBase.ToolTipFilter;
            btnAddItems.ToolTipText = controllerBase.ToolTipAddItems;
            btnConcludeItems.ToolTipText = controllerBase.ToolTipConcludeItems;
        }

        private void SetButtonStatus(BaseController controllerBase)
        {
            btnInsert.Enabled = controllerBase.IsInsertEnabled;
            btnEdit.Enabled = controllerBase.IsEditEnabled;
            btnDelete.Enabled = controllerBase.IsDeleteEnabled;
            btnFilter.Enabled = controllerBase.IsFilterEnabled;
            btnAddItems.Enabled = controllerBase.IsAddItemsEnabled;
            btnConcludeItems.Enabled = controllerBase.IsConcludeItemsEnabled;
        }

        private void btnInsert_Click(object sender, EventArgs e)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _controller.Add();
        }

        private void btnConcludeItems_Click(object sender, EventArgs e)
        {
            _controller.ConcludeItems();
        }
    }
}