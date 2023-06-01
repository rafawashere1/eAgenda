using System.Text.RegularExpressions;

namespace eAgenda.WinApp.ContactModule
{
    public class Contact : BaseEntity<Contact>
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string JobTitle { get; set; }

        public Contact(string name, string phone, string email, string company, string jobTitle)
        {
            Name = name;
            Phone = phone;
            Email = email;
            Company = company;
            JobTitle = jobTitle;
        }

        public override void UpdateInfos(Contact updatedContact)
        {
            updatedContact.Name = Name;
            updatedContact.Phone = Phone;
            updatedContact.Email = Email;
            updatedContact.Company = Company;
            updatedContact.JobTitle = JobTitle;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Nome: {Name}, Empresa: {Company}";
        }

        public override List<string> Validate()
        {
            List<string> errors = new();

            bool isPhoneValid = Regex.IsMatch(Phone, @"^\(\d{2}\) \d{5}-\d{4}$");
            bool isEmailValid = Regex.IsMatch(Email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");

            if (string.IsNullOrWhiteSpace(Name))
                errors.Add("O campo 'nome' é obrigatório");

            if (Phone == "(  )      -")
                errors.Add("O campo 'telefone' é obrigatório");
            else if (!isPhoneValid)
                errors.Add("O campo 'telefone' está inválido");

            if (string.IsNullOrWhiteSpace(Email))
                errors.Add("O campo 'email' é obrigatório");
            else if (!isEmailValid)
                errors.Add("O campo 'email' está inválido");

            return errors;
        }

        public override bool Equals(object? obj)
        {
            return obj is Contact contact &&
                   Id == contact.Id &&
                   Name == contact.Name &&
                   Phone == contact.Phone &&
                   Email == contact.Email &&
                   Company == contact.Company &&
                   JobTitle == contact.JobTitle;
        }
    }
}
