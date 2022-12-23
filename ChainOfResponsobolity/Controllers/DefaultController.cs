using ChainOfResponsobolity.ChainOfResponsobilityDesignPattern;
using ChainOfResponsobolity.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ChainOfResponsobolity.Controllers
{
    public class DefaultController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(WithDraw p)
        {
            Employee treasurer=new Treasurer();
            Employee manager = new Manager();
            Employee director=new Director();
            Employee areaDirector=new AreaDirector();  
            
            treasurer.SetNextApprover(manager);
            manager.SetNextApprover(director);
            director.SetNextApprover(areaDirector);

            treasurer.ProcessRequest(p);
            return View();
        }
    }
}
