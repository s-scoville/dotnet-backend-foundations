using InterfacesBasics.Notifications;

List<INotification> notifications = new List<INotification>();
notifications.Add(new EmailNotification());
notifications.Add(new TextNotification());
notifications.Add(new PushNotification());

foreach (INotification n in notifications)
{
    n.Send();
    Console.WriteLine();
}