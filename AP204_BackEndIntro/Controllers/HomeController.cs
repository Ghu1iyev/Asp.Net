using Microsoft.AspNetCore.Mvc;

namespace AP204_BackEndIntro.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index( int id)
        {
            return Content(id.ToString());
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Product = "Phone";
            ViewData["Count"]=5;
            TempData["Price"] = "570 $";
            return RedirectToAction("Index");
            return View();
        }
        public ActionResult Contact()
        {
           
           
            return View();
        }
        public ActionResult FAQ(string name,string surname)
        {
            string fullname = $"{name} ,{surname}";
            return Content(fullname);
        }
    }
}
