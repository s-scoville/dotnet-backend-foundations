namespace InterfacesBasics.Notifications
{
    internal class PushNotification : INotification
    {
        public void Send()
        {
            Console.WriteLine("You send a push notification to the customer's phone.");
        }
    }
}
