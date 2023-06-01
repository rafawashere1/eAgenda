using e_Agenda.WinApp.TasksModule;

namespace e_Agenda.WinApp.TaskModule
{
    public class TaskController : BaseController
    {
        public override string ToolTipAdd => "Inserir nova tarefa";

        public override string ToolTipEdit => "Editar tarefa existente";

        public override string ToolTipDelete => "Excluir tarefa existente";

        public override void Insert()
        {
            TaskForm taskForm = new();

            DialogResult dialogResult = taskForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                //
            }
        }

        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override void Edit()
        {
            throw new NotImplementedException();
        }

        public override UserControl GetListing()
        {
            return new ListingTaskControl();
        }

        public override string GetTypeRegistration()
        {
            return "Cadastro de Tarefas";
        }
    }
}
