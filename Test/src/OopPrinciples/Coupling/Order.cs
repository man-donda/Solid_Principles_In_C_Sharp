namespace Test.src.OopPrinciples.Coupling
{
    public class Order
    {
        private readonly INotificationService notificationService;

        public Order(INotificationService notificationService)
        {
            this.notificationService = notificationService;
        }
        public void PlaceOrder()
        {
           notificationService.SendNotification("Order placed successfully.");
        }
    }
}