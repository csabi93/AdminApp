using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System.Web.Mvc;
using BLL.ViewModels;
using BLL.TechFuncServices;

namespace Maintenanceapp2.Controllers
{
    public class TechFuncController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TechFuncs_Create([DataSourceRequest]DataSourceRequest request, TechFuncViewModel tech)
        {
            if (ModelState.IsValid)
            {
                TechFuncservices.CreateTechFuncModel(tech);  
            }   
            return Json(new[] { tech }.ToDataSourceResult(request, ModelState));     
        }
        public ActionResult GetAllTechFunc([DataSourceRequest]DataSourceRequest request)
        {      
                return Json(TechFuncservices.GetTechFuncDatasource(request), JsonRequestBehavior.AllowGet);      
        }

        public ActionResult TechFuncs_Update([DataSourceRequest]DataSourceRequest request, TechFuncViewModel tech)
        {
             if (ModelState.IsValid)
             {
                TechFuncservices.UpdateTechFuncModel(tech);
            }     
             return Json(new[] { tech }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult TechFuncs_Destroy([DataSourceRequest]DataSourceRequest request, TechFuncViewModel tech)
        {
            if (ModelState.IsValid)
            {
                TechFuncservices.DestroyTechFuncModel(tech);
            } 
            return Json(new[] { tech }.ToDataSourceResult(request, ModelState));
        }

    }
}