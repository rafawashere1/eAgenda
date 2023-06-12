namespace eAgenda.WinApp.Shared
{
    public abstract class FileBaseRepository<T> where T : BaseEntity<T>
    {
        protected int Counter { get; set; }
        protected DataContext DataContext { get; set; }

        public FileBaseRepository(DataContext dataContext)
        {
            DataContext = dataContext;
            UpdateCounter();
        }

        public void Insert(T register)
        {
            List<T> registers = GetRegisters();

            Counter++;

            register.Id = Counter;

            registers.Add(register);

            DataContext.SendRegistersToJsonFile();
        }

        public void Edit(int id, T register)
        {
            SelectById(id).UpdateInfos(register);

            DataContext.SendRegistersToJsonFile();
        }

        public void Delete(T register)
        {
            GetRegisters().Remove(register);

            DataContext.SendRegistersToJsonFile();
        }

        public T SelectById(int id)
        {
            return GetRegisters().FirstOrDefault(x => x.Id == id);
        }

        public List<T> GetAll()
        {
            return GetRegisters();
        }

        private void UpdateCounter()
        {
            if (GetRegisters().Count > 0)
                Counter = GetRegisters().Max(x => x.Id);
        }

        protected abstract List<T> GetRegisters();
    }
}
