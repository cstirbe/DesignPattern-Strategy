namespace WebApplication2
{
    public class SmsNotifier : INotifier
    {
        public string Notify()
        {
            return NotificationType.Sms.ToString();
        }
    }
}
