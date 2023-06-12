using eAgenda.Domain.AppointmentModule;
using eAgenda.Domain.ContactModule;
using eAgenda.Domain.SpendingModule;
using Task = eAgenda.Domain.TaskModule.Task;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;
using System.Text.Json.Serialization;
using MyFile = System.IO.File;

namespace eAgenda.Infra.Data.File.Shared
{
    public class DataContext
    {
        private const string FILE_NAME = "Shared\\eAgenda.json";

        public List<Contact> Contacts { get; set; }
        public List<Appointment> Appointments { get; set; }
        public List<Task> Tasks { get; set; }
        public List<Spending> Spendings { get; set; }
        public List<Category> Categories { get; set; }

        public DataContext()
        {
            Contacts = new List<Contact>();
            Appointments = new List<Appointment>();
            Tasks = new List<Task>();
            Spendings = new List<Spending>();
            Categories = new List<Category>();
        }

        public DataContext(bool loadData) : this()
        {
            if (loadData)
                LoadRegistersFromJsonFile();
        }

        #region Binary Serializer
        public void SendRegistersToBinaryFile()
        {
            BinaryFormatter serializer = new();

            MemoryStream stream = new();

            serializer.Serialize(stream, this);

            MyFile.WriteAllBytes(FILE_NAME, stream.ToArray());
        }

        public void LoadRegistersFromBinaryFile()
        {
            BinaryFormatter serializer = new();

            MemoryStream stream = new(MyFile.ReadAllBytes(FILE_NAME));

            DataContext ctx = serializer.Deserialize(stream) as DataContext;

            Contacts = ctx.Contacts;
            Appointments = ctx.Appointments;
            Tasks = ctx.Tasks;
            Spendings = ctx.Spendings;
            Categories = ctx.Categories;
        }
        #endregion

        #region Json Serializer
        public void SendRegistersToJsonFile()
        {
            MyFile.WriteAllText(FILE_NAME, JsonSerializer.Serialize(this, GetConfiguration()));
        }

        public void LoadRegistersFromJsonFile()
        {

            if (MyFile.Exists(FILE_NAME))
            {
                if (MyFile.ReadAllText(FILE_NAME).Length > 0)
                {
                    DataContext ctx = JsonSerializer.Deserialize<DataContext>(MyFile.ReadAllText(FILE_NAME), GetConfiguration());

                    Contacts = ctx.Contacts;
                    Appointments = ctx.Appointments;
                    Tasks = ctx.Tasks;
                    Spendings = ctx.Spendings;
                    Categories = ctx.Categories;
                }
            }
        }
        #endregion

        #region Xml Serializer
        public void SendRegistersToXmlFile()
        {
            XmlSerializer serializer = new(typeof(DataContext));

            MemoryStream stream = new();

            serializer.Serialize(stream, this);

            MyFile.WriteAllBytes(FILE_NAME, stream.ToArray());
        }

        public void LoadRegistersFromXmlFile()
        {
            XmlSerializer serializer = new(typeof(DataContext));

            MemoryStream stream = new(MyFile.ReadAllBytes(FILE_NAME));

            DataContext ctx = serializer.Deserialize(stream) as DataContext;

            Contacts = ctx.Contacts;
            Appointments = ctx.Appointments;
            Tasks = ctx.Tasks;
            Spendings = ctx.Spendings;
            Categories = ctx.Categories;
        }
        #endregion

        private static JsonSerializerOptions GetConfiguration()
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;
            options.ReferenceHandler = ReferenceHandler.Preserve;

            return options;
        }
    }
}
