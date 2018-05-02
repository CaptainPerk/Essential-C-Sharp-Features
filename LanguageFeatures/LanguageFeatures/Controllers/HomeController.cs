using Microsoft.AspNetCore.Mvc;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {

            return View("Index", new[] { "Bob", "Joe", "Alice"});
        }
    }
}
