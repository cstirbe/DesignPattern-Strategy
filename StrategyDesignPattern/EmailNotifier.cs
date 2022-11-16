namespace WebApplication2
{
    public class EmailNotifier : INotifier
    {
        public string Notify()
        {
            return NotificationType.Email.ToString();
        }
    }
}
