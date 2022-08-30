namespace LSTMEKanban.Internal.Services
{
    public class PrintTaskDbService
    {
        private readonly DataContext _appDataContext;

        public PrintTaskDbService(DataContext dataContext)
        {
            _appDataContext = dataContext;
        }

        public void AddPrintTask(PrintTask printTask)
        {
            _appDataContext.PrintTasks.Add(printTask);
        }

        public IList<PrintTask> GetWaitingPrintTasks()
        {
            return _appDataContext.PrintTasks.Where(task => task.CurrentState == State.Ready).ToList();
        }

        public IList<PrintTask> GetInProgressPrintTasks()
        {
            return _appDataContext.PrintTasks.Where(task => task.CurrentState == State.InProgress).ToList();
        }
        public IList<PrintTask> GetDonePrintTasks()
        {
            return _appDataContext.PrintTasks.Where(task => task.CurrentState == State.Done).ToList();
        }
    }
}
