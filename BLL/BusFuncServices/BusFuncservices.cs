using DAL.Models;
using DAL.BusFuncs;
using Kendo.Mvc.UI;
using BLL.ViewModels;
using System.Linq;
using Kendo.Mvc.Extensions;
using DAL;
using System.Collections.Generic;

namespace BLL.BusFuncServices
{
    public class BusFuncservices
    {
       
        public static void CreateBusFuncModel(BusFuncViewModel bus)
        {
            
             BusFuncMethod.CreateBusFuncModel(ConvertToBusFunc(bus)) ;
        }
        public static void DestroyBusFuncModel(BusFuncViewModel bus)
        {
            BusFuncMethod.DestroyBusFuncModel(ConvertToBusFunc(bus));
        }
        public static DataSourceResult GetBusFuncDatasource([DataSourceRequest]DataSourceRequest request)
        {
            return BusFuncMethod.GetBusFuncModels(request);
            }
        public static List<BusFuncViewModel> GetAllBusFuncsWithID_And_Code()
        {
            var dbe = CreateToDatabase.DataSourceopen();
            List<BusFuncViewModel> result = new List<BusFuncViewModel>();
            IQueryable<DAL.BusFunc> busfuncs = dbe.BusFuncs;
            result = busfuncs.Select(busf => new BusFuncViewModel
            {
                ID= busf.ID,
                Code= busf.Code

            }).ToList();
            return result;
        }

        public static void UpdateBusFuncModel(BusFuncViewModel bus)
        {
            BusFuncMethod.UpdateBusFuncModel(ConvertToBusFunc(bus));
        }
        public static DAL.BusFunc ConvertToBusFunc(BusFuncViewModel bus)
        {

            DAL.BusFunc b= new DAL.BusFunc
            {
                ID = bus.ID,
                Code = bus.Code,
                Name = bus.Name,
                Comment = bus.Comment,
                LocalizedTitle = bus.LocalizedTitle,
                TechFuncID = bus.TechFuncID,
                DsbTileCssClass = bus.DsbTileCssClass,
                IsCombo = bus.IsCombo,
                FleetOnly = bus.FleetOnly
            };
            return b;
        }
       
    }
}
