using Microsoft.AspNetCore.Mvc;

namespace wmq.Client.Controllers
{
    
    public class UrlController : Controller
    {
        
        public IActionResult Index()
        {
             return View();
        }
    }
}