using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System.Web.Mvc;
using BLL.BusParServices;
using BLL.ViewModels;

namespace Maintenanceapp2.Controllers
{
    public class BusParController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult BusPars_Create([DataSourceRequest]DataSourceRequest request, BusParViewModel par)
        {
            if (ModelState.IsValid)
            {
                BusParservices.CreateBusParModel(par);

            }           
            return Json(new[] { par }.ToDataSourceResult(request, ModelState));
        }
        public ActionResult GetAllBusPars([DataSourceRequest]DataSourceRequest request)
        {

            return Json(BusParservices.GetBusParDatasource(request), JsonRequestBehavior.AllowGet);
        }
        public ActionResult BusPars_Update([DataSourceRequest]DataSourceRequest request, BusParViewModel par)
        {
            if (ModelState.IsValid)
            {
                BusParservices.UpdateBusParModel(par);
            }
            return Json(new[] { par }.ToDataSourceResult(request, ModelState));
        }
        public ActionResult BusPars_Destroy([DataSourceRequest]DataSourceRequest request, BusParViewModel par)
        {
            if (ModelState.IsValid)
            {
                BusParservices.DestroyBusParModel(par);
            }
            return Json(new[] { par }.ToDataSourceResult(request, ModelState));
        }
    }
}