using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace MVCALUNO.Controllers
{
    public class HelloWorldController : Controller
    {
         // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome(string nome, int vezes)
        {
            return View();
        }
    }
}