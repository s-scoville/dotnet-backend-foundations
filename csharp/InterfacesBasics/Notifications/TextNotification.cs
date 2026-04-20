namespace InterfacesBasics.Notifications
{
    internal class TextNotification : INotification
    {
        public void Send()
        {
            Console.WriteLine("You send a text message to the customer.");
        }
    }
}
