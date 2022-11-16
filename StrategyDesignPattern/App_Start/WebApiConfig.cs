using System.Web.Http;

namespace WebApplication2
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            NotificationStrategy.Instance.RegisterNotifier(NotificationType.Email, new EmailNotifier());
            NotificationStrategy.Instance.RegisterNotifier(NotificationType.Push, new PushNotifier());
            NotificationStrategy.Instance.RegisterNotifier(NotificationType.Sms, new SmsNotifier());

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                "DefaultApi",
                "api/{controller}/{id}",
                new { id = RouteParameter.Optional }
            );
        }
    }
}
