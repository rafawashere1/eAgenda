namespace eAgenda.WinApp.Shared
{
    public abstract class BaseEntity<T>
    {
        public int Id { get; set; }

        public abstract void UpdateInfos(T updatedRegister);

        public abstract List<string> Validate();
    }
}
