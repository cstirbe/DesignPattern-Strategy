using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var smsNotifier = NotificationStrategy.Instance.GetNotifier(NotificationType.Sms);
            var emailNotifier = NotificationStrategy.Instance.GetNotifier(NotificationType.Email);
            var pushNotifier = NotificationStrategy.Instance.GetNotifier(NotificationType.Push);

            var response1 = smsNotifier.Notify();
            var response2 = emailNotifier.Notify();
            var response3 = pushNotifier.Notify();

            ViewBag.Title = "Design Patterns - Strategy";
            ViewBag.Message1 = $"{smsNotifier.GetType()}: {response1}";
            ViewBag.Message2 = $"{smsNotifier.GetType()}: {response2}";
            ViewBag.Message3 = $"{pushNotifier.GetType()}: {response3}";

            return View();
        }
    }
}
