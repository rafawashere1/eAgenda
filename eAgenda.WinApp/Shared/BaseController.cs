namespace eAgenda.WinApp.Shared
{
    public abstract class BaseController
    {
        public abstract string ToolTipAdd { get; }
        public abstract string ToolTipEdit { get; }
        public abstract string ToolTipDelete { get; }

        public abstract void Insert();

        public abstract void Edit();

        public abstract void Delete();

        public virtual void Filter()
        {
        }
        
        public virtual void Add()
        {
        }

        public virtual void ConcludeItems()
        {
        }

        public abstract UserControl GetListing();

        public abstract string GetTypeRegistration();
    }
}
