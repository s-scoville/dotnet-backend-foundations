namespace InterfacesBasics.Notifications
{
    public class EmailNotification : INotification
    {
        public void Send()
        {
            Console.WriteLine("You send an email notification to the customer.");
        }
    }
}
