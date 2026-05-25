namespace Test.src.OopPrinciples.Coupling
{
    public class SmsSender : INotificationService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine("Sms message: " + message);
        }
    }
}