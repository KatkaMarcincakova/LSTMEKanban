namespace LSTMEKanban.Tests.Entities.DTOs
{
    [TestClass]
    public class PrintTaskTest
    {
        [TestMethod]
        public void UpdateStateTest()
        {
            PrintTask printTask = new PrintTask("name", "url", State.Ready);
            printTask.UpdateState(State.InProgress);

            Assert.IsTrue(printTask.CurrentState == State.InProgress);
        }
    }
}