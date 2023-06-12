namespace eAgenda.WinApp.SpendingModule
{
    public class Spending : BaseEntity<Spending>
    {
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public decimal Value { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public List<Category> Categories { get; set; }

        public Spending()
        {
            
        }

        public Spending(string description, DateTime date, decimal value, PaymentMethod paymentMethod)
        {
            Description = description;
            Date = date;
            Value = value;
            PaymentMethod = paymentMethod;
            Categories = new List<Category>();
        }

        public override void UpdateInfos(Spending updatedRegister)
        {
            Description = updatedRegister.Description;
            Date = updatedRegister.Date;
            Value = updatedRegister.Value;
            PaymentMethod = updatedRegister.PaymentMethod;
            Categories = updatedRegister.Categories;
        }

        public override List<string> Validate()
        {
            List<string> errors = new();

            if (string.IsNullOrWhiteSpace(Description))
                errors.Add("O campo 'descrição' é obrigatório");

            if (Date == default)
                errors.Add("O campo 'data' é obrigatório");

            if (Value <= 0)
                errors.Add("O campo 'valor' precisa ser maior que 0");

            if (PaymentMethod == PaymentMethod.None)
                errors.Add("O campo 'forma de pagamento' é obrigatório");

            return errors;
        }
    }
}
