using DAL.TechFuncs;
using Kendo.Mvc.UI;
using BLL.ViewModels;
using DAL.Models;
using System.Linq;
using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace BLL.TechFuncServices
{
    public class TechFuncservices
    {
        
        public static  void CreateTechFuncModel(TechFuncViewModel bus)
        {     
           TechFuncMethod.CreateTechFuncModel(MapTechFunc(bus));
        }
        public static void DestroyTechFuncModel(TechFuncViewModel bus)
        {

            TechFuncMethod.DestroyTechFuncModel(MapTechFunc(bus));
        }
        public static List<TechFuncViewModel> GetTechFuncsWith_ID_And_Code()
        {
            
            List<TechFuncViewModel> result = new List<TechFuncViewModel>();
            result = TechFuncMethod.getTechFuncs().Select(product => new TechFuncViewModel
            {
                ID = product.ID,
                Code = product.Code

            }).ToList();
            return result;
        }
        public static DataSourceResult GetTechFuncDatasource([DataSourceRequest]DataSourceRequest request)
        {
            DataSourceResult result = TechFuncMethod.getTechFuncs(request).ToDataSourceResult(request, tech => new TechFuncViewModel
            {
                ID = tech.ID,
                Code = tech.Code,
                Title = tech.Title,
                Comment = tech.Comment
            });
           
            return result;
        }
        public static DataSourceResult GetTechFuncByIDDatasource(int id, [DataSourceRequest]DataSourceRequest request)
        {
          
            DataSourceResult result = TechFuncMethod.TechFuncByID(id, request).ToDataSourceResult(request, tech => new TechFuncViewModel
            {
                ID = tech.ID,
                Code = tech.Code,
                Title = tech.Title,
                Comment = tech.Comment
            });
            return result;
        }
        public static void UpdateTechFuncModel(TechFuncViewModel bus)
        {
            TechFuncMethod.UpdateTechFuncModel(MapTechFunc(bus));
        }
        public static DAL.TechFunc MapTechFunc(TechFuncViewModel bus)
        {
            DAL.TechFunc b = new DAL.TechFunc
            {
                ID = bus.ID,
                Code=bus.Code,
                Comment=bus.Comment,
                Title=bus.Title
            };
            return b;
        }
    }
}
