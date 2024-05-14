using Microsoft.AspNetCore.Mvc;

namespace EcommerceBookShop.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
