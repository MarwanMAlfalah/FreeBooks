using Microsoft.AspNetCore.Mvc;

namespace WebBook.Areas.Admin.Controllers
{
    public class AccountsController : Controller
    {
        [Area("Admin")]
        public IActionResult Login()
        {
            return View();
        }
    }
}
