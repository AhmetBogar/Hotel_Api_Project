using Microsoft.AspNetCore.Mvc;

namespace RapidApiConsume.Controllers
{
    public class ImdbController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
