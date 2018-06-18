using Microsoft.AspNetCore.Mvc;

namespace WishList.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View("Index");

        public IActionResult Error() => View("Error");
    }
}