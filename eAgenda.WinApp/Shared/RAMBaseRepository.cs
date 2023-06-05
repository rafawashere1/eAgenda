namespace eAgenda.WinApp.Shared
{
    public class RAMBaseRepository<T> where T : BaseEntity<T>
    {
        protected List<T> registersList;
        protected int registersCounter = 0;

        public virtual void Insert(T register)
        {
            registersCounter++;

            register.Id = registersCounter;

            registersList.Add(register);
        }

        public virtual void Edit(int id, T updatedRegister)
        {
            T selectedRegister = SelectById(id);

            selectedRegister.UpdateInfos(updatedRegister);
        }

        public virtual void Edit(T selectedRegister, T updatedRegister)
        {
            selectedRegister.UpdateInfos(updatedRegister);
        }

        public virtual void Delete(int id)
        {
            T selectedRegister = SelectById(id);

            registersList.Remove(selectedRegister);
        }

        public virtual void Delete(T selectedRegister)
        {
            registersList.Remove(selectedRegister);
        }

        public virtual T SelectById(int id)
        {
            return registersList.Find(x => x.Id == id);
        }

        public virtual List<T> SelectAll()
        {
            return registersList;
        }

        public bool HasRegister()
        {
            return registersList.Count > 0;
        }

        public bool HasRegister(List<T> registersList)
        {
            return registersList.Count > 0;
        }
    }
}
