using Microsoft.AspNetCore.Mvc;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            object[] data = { 275M, 29.95M, "apple", "orange", 100, 10};
            decimal total = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] is decimal d)
                {
                    total += d;
                }
            }

            return View("Index", new[] {$"Total: {total:C2}"});
        }
    }
}
