using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace rocket_elevators_customer_portal.Controllers
{
    public class CustomerController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult profile()
        {
            return View();
        }
        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}