using DAL.BusPars;
using System.Collections.Generic;
using System.Linq;
using Kendo.Mvc.UI;
using DAL.Models;
using BLL.ViewModels;
using Kendo.Mvc.Extensions;
using DAL;

namespace BLL.BusParServices
{
    public class BusParservices
    {
        public static void CreateBusParModel(BusParViewModel bus)
        {
             BusParMethod.CreateBusParModel(ConvertToBusPar(bus));
        }
        public static void DestroyBusParModel(BusParViewModel bus)
        {
            BusParMethod.DestroyBusParModel(ConvertToBusPar(bus));
        }
        public static DataSourceResult GetBusParDatasource([DataSourceRequest]DataSourceRequest request)
        {
            
            DataSourceResult result = BusParMethod.get_BusPar().ToDataSourceResult(request, busfunc => new BusParViewModel
            {
                ID = busfunc.ID,
                Name = busfunc.Name,
                Code = busfunc.Code,
                ValueType=busfunc.ValueType,
                Comment = busfunc.Comment

            });
           
            return result;
        }
        public static List<BusParViewModel> GetBusParWith_ID_And_Code()
        {
            var db = new Model1();
            List<BusParViewModel> result = new List<BusParViewModel>();
            IQueryable<DAL.BusPar>buspars = db.BusPars;
            result = buspars.Select(bpar => new BusParViewModel
            {
                ID = bpar.ID,
                Code = bpar.Code

            }).ToList();
            return result;
        }
       
        public static void UpdateBusParModel(BusParViewModel bus)
        {
            BusParMethod.BusParModelUpdate(ConvertToBusPar(bus));
        }
        public static DataSourceResult GetBusParByIDDatasource(int id, [DataSourceRequest]DataSourceRequest request)
        {
            return BusParMethod.HierarchyBusParDataSource(id, request);
        }

        

        public static DAL.BusPar ConvertToBusPar(BusParViewModel bus)
        {
            DAL.BusPar b = new DAL.BusPar
            {
                ID = bus.ID,
                Code = bus.Code,
                Name = bus.Name,
                Comment = bus.Comment,
                ValueType=bus.ValueType
            };
            return b;
        }
    }
}
