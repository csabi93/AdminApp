using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System.Web.Mvc;
using BLL.BusParOfBusFuncServices;
using BLL.ViewModels;


namespace Maintenanceapp2.Controllers
{
    public class BusParOfBusController : Controller
    {
        public ActionResult Index()
        {
            ViewData["buspars"] = BusParOfBusFuncservices.BusParPopulate(); 
            ViewData["busfuncs"] = BusParOfBusFuncservices.BusFuncPopulate();
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult BusParOfFuncs_Create([DataSourceRequest] DataSourceRequest request,
            BusParOfBusFuncViewModel bpar)
        {   
            string val4 = "Hibás intervallum megadás";         
            byte state=0;           
            if (bpar != null && ModelState.IsValid)
            {

                state = BusParOfBusFuncservices.CreateBusParOfBusFuncModel(bpar);
                if (state==4)
                    ModelState.AddModelError("Value_DateInterval_To", val4);

            }

            if (state != 0)
                return Json(ModelState.ToDataSourceResult());

            else
                return Json(new[] { bpar }.ToDataSourceResult(request, ModelState));
            
        }

        public ActionResult GetBusParOfBusFuncs([DataSourceRequest]DataSourceRequest request)
        {
            return Json(BusParOfBusFuncservices.GetBusParOfBusFuncsDatasource(request), JsonRequestBehavior.AllowGet);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult BusParOfBusFuncs_Update([DataSourceRequest]DataSourceRequest request, BusParOfBusFuncViewModel bpar)
        {
            string val4 = "Hibás intervallum megadás";
            string notValid = "Hibás adatmegadás";
            byte state=0;

            if (bpar.Value_DateInterval_From != null && (bpar.Value_FeatureOption != null || bpar.Value_MaxCount != null))
            {
                ModelState.AddModelError("Value_DateInterval_From", notValid);
                return Json(ModelState);
            }
            if(bpar.Value_DateInterval_To != null && (bpar.Value_FeatureOption != null || bpar.Value_MaxCount != null))
            {
                ModelState.AddModelError("Value_DateInterval_From", notValid);
                return Json(ModelState);
            }
            if(bpar.Value_FeatureOption !=null && (bpar.Value_DateInterval_From !=null || bpar.Value_DateInterval_To != null || bpar.Value_MaxCount!=null))
            {
                ModelState.AddModelError("Value_FeatureOption", notValid);
                return Json(ModelState);
            }
            if (bpar.Value_MaxCount != null && (bpar.Value_DateInterval_From != null || bpar.Value_DateInterval_To != null || bpar.Value_FeatureOption != null))
            {
                ModelState.AddModelError("Value_MaxCount", notValid);
                return Json(ModelState);
            }
            if (bpar != null && ModelState.IsValid)
            {

                state = BusParOfBusFuncservices.UpdateBusParOfBusFuncModel(bpar);

                if (state == 4)
                    ModelState.AddModelError("Value_DateInterval_From", val4);

            }
            if (state != 0)
                return Json(ModelState.ToDataSourceResult());
            else
            {
                
                return Json(new[] { bpar }.ToDataSourceResult(request, ModelState));
            }

        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult BusParOfFuncs_Destroy([DataSourceRequest]DataSourceRequest request, BusParOfBusFuncViewModel bpar)
        {
            
            if (bpar != null)
            {
                BusParOfBusFuncservices.DestroyBusParModel(bpar);
            }
            return Json(new[] { bpar }.ToDataSourceResult(request, ModelState));    

        }
        public int GetValueType (int id)
        {
           return BusParOfBusFuncservices.GetVal(id);
        }
    }
 }