namespace eAgenda.WinApp.SpendingModule
{
    public class Category : BaseEntity<Category>
    {
        public string Title { get; set; }
        public List<Spending> Spendings { get; set; }

        public Category(string title)
        {
            Title = title;
            Spendings = new List<Spending>();
        }
        public override void UpdateInfos(Category updatedRegister)
        {
            Title = updatedRegister.Title;
        }

        public override List<string> Validate()
        {
            List<string> errors = new();

            if (string.IsNullOrWhiteSpace(Title))
                errors.Add("O campo 'título' é obrigatório");

            return errors;
        }
    }
}
