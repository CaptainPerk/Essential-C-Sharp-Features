using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ViewResult> Index()
        {
            long? length = await MyAsyncMethods.GetPageLength();
            return View(new[] {$"Length: {length}"});
        }
    }
}
