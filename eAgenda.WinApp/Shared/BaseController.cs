namespace eAgenda.WinApp.Shared
{
    public abstract class BaseController
    {
        public abstract string ToolTipInsert { get; }
        public abstract string ToolTipEdit { get; }
        public abstract string ToolTipDelete { get; }
        public virtual string ToolTipFilter { get; }
        public virtual string ToolTipAddItems { get; }
        public virtual string ToolTipConcludeItems { get; }

        public virtual bool IsInsertEnabled => true;
        public virtual bool IsEditEnabled => true;
        public virtual bool IsDeleteEnabled => true;

        public virtual bool IsFilterEnabled => false;
        public virtual bool IsAddItemsEnabled => false;
        public virtual bool IsConcludeItemsEnabled => false;

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
