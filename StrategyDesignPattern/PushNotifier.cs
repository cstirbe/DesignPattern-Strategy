namespace WebApplication2
{
    public class PushNotifier : INotifier
    {
        public string Notify()
        {
            return NotificationType.Push.ToString();
        }
    }
}
