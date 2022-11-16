using Ninject;

namespace WebApplication2
{
    public class NotificationStrategy
    {
        private readonly IKernel _kernel;

        private static NotificationStrategy _instance;

        public static NotificationStrategy Instance => _instance ?? (_instance = new NotificationStrategy());

        private NotificationStrategy()
        {
            _kernel = new StandardKernel();
        }

        public INotifier GetNotifier(NotificationType notificationType)
        {
            return _kernel.Get<INotifier>(notificationType.ToString());
        }

        public void RegisterNotifier(NotificationType notificationType, INotifier notifier)
        {
            _kernel.Bind<INotifier>().To(notifier.GetType()).Named(notificationType.ToString());
        }
    }
}
