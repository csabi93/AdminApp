using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System.Web.Mvc;
using BLL.ViewModels;
using BLL.BusFuncServices;
using BLL.TechFuncServices;
using BLL.BusParServices;

namespace UIL.Controllers
{
    public class BusFuncController : Controller
    {
        public ActionResult Index()
        {
            ViewData["techfuncs"] = TechFuncservices.GetTechFuncsWith_ID_And_Code();
            return View();
        }
        public ActionResult BusFuncs_Create([DataSourceRequest]DataSourceRequest request, BusFuncViewModel bus)
        {
            if (ModelState.IsValid)
            {                                                   
                    BusFuncservices.CreateBusFuncModel(bus);                                        
            }
           
            return Json(new[] { bus }.ToDataSourceResult(request, ModelState));
        }
        public  ActionResult GetAllBusFunc([DataSourceRequest]DataSourceRequest request)
        {
         
            return Json(BusFuncservices.GetBusFuncDatasource(request), JsonRequestBehavior.AllowGet);

        }
        public ActionResult HierarchyBinding_TechFuncs(int techfuncID, [DataSourceRequest] DataSourceRequest request)
        {
            return Json(TechFuncservices.GetTechFuncByIDDatasource(techfuncID,request), JsonRequestBehavior.AllowGet);
        }
        public ActionResult HierarchyBinding_BusPars(int busparID, [DataSourceRequest] DataSourceRequest request)
        {
            return Json(BusParservices.GetBusParByIDDatasource(busparID, request), JsonRequestBehavior.AllowGet);
        }
        public ActionResult BusFuncs_Update([DataSourceRequest]DataSourceRequest request, BusFuncViewModel bus)
        {
            

            if (ModelState.IsValid)
            {
                BusFuncservices.UpdateBusFuncModel(bus);           
            }
            return Json(new[] { bus }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult BusFuncs_Destroy([DataSourceRequest]DataSourceRequest request, BusFuncViewModel bus)
        {
            if (ModelState.IsValid)
            {
                BusFuncservices.DestroyBusFuncModel(bus);                
            }
            return Json(new[] { bus }.ToDataSourceResult(request, ModelState));
        }

    }
}