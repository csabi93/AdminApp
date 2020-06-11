using BLL.BusFuncServices;
using BLL.BusParServices;
using System.Web.Mvc;

namespace Maintenanceapp2.Controllers
{
    public class BusFuncWithBusParController : Controller
    {
        // GET: BusFuncWithBusPar
        public ActionResult Index()
        {
            ViewData["buspars"] = BusParservices.GetBusParWith_ID_And_Code();
            ViewData["busfuncs"] = BusFuncservices.GetAllBusFuncsWithID_And_Code();
            return View();
        }
    }
}