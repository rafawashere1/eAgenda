namespace eAgenda.WinApp.SpendingModule
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();

            this.ConfigureDialog();
        }

        public Category GetCategory()
        {
            int id = Convert.ToInt32(txtId.Text);

            string title = txtTitle.Text;

            Category category = new(title);

            if (id > 0)
                category.Id = id;

            return category;
        }

        public void ConfigureForm(Category category)
        {
            txtId.Text = category.Id.ToString();

            txtTitle.Text = category.Title;
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            Category category = GetCategory();

            List<string> errors = category.Validate();

            if (errors.Count > 0)
            {
                MainForm.Instance.UpdateFooter(errors[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
