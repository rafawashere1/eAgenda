using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;

namespace eAgenda.WinApp.Shared
{
    public abstract class FileBaseRepository<T> where T : BaseEntity<T>
    {
        protected int counter;

        protected List<T> registers;

        public FileBaseRepository()
        {
            if (File.Exists(GetFileName()))
                LoadRegistersFromJsonFile();

            registers = new List<T>();
        }

        public void Insert(T register)
        {
            counter++;

            register.Id = counter;

            registers.Add(register);

            SendRegistersToJsonFile();
        }

        public void Edit(int id, T register)
        {
            SelectById(id).UpdateInfos(register);

            SendRegistersToJsonFile();
        }

        public void Delete(T register)
        {
            registers.Remove(register);

            SendRegistersToJsonFile();
        }

        public T SelectById(int id)
        {
            return registers.FirstOrDefault(x => x.Id == id);
        }

        public List<T> GetAll()
        {
            return registers;
        }

        private void UpdateCounter()
        {
            counter = registers.Max(x => x.Id);
        }

        #region Binary Serializer
        protected void SendRegistersToBinaryFile()
        {
            BinaryFormatter serializer = new();

            MemoryStream stream = new();

            serializer.Serialize(stream, registers);

            File.WriteAllBytes(GetFileName(), stream.ToArray());
        }

        protected void LoadRegistersFromBinaryFile()
        {
            BinaryFormatter serializer = new();

            MemoryStream stream = new(File.ReadAllBytes(GetFileName()));

            registers = serializer.Deserialize(stream) as List<T>;

            UpdateCounter();
        }
        #endregion

        #region Json Serializer
        protected void SendRegistersToJsonFile()
        {
            File.WriteAllText(GetFileName(), JsonSerializer.Serialize(registers));
        }

        protected void LoadRegistersFromJsonFile()
        {
            registers = JsonSerializer.Deserialize<List<T>>(File.ReadAllText(GetFileName()));
        }
        #endregion

        #region Xml Serializer
        protected void SendRegistersToXmlFile()
        {
            XmlSerializer serializer = new(typeof(List<T>));

            MemoryStream stream = new();

            serializer.Serialize(stream, registers);

            File.WriteAllBytes(GetFileName(), stream.ToArray());
        }

        protected void LoadRegistersFromXmlFile()
        {
            XmlSerializer serializer = new(typeof(List<T>));

            MemoryStream stream = new(File.ReadAllBytes(GetFileName()));

            registers = serializer.Deserialize(stream) as List<T>;

            UpdateCounter();
        }
        #endregion

        protected abstract string GetFileName();
    }
}
