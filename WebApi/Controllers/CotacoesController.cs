using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class CotacoesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
