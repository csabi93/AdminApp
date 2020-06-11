using DAL.Models;
using System.Linq;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;

namespace DAL.BusFuncs
{
    public class BusFuncMethod
    {
        public static BusFunc CreateBusFuncModel(BusFunc bus)
        {
         
            CreateToDatabase.DbCreate(BusFuncModel(bus));
            return BusFuncModel(bus);     
        }
        public static DataSourceResult GetBusFuncModels([DataSourceRequest]DataSourceRequest request)
        {
            var dbe = CreateToDatabase.DataSourceopen();
            IQueryable<BusFunc> busfuncs = dbe.BusFuncs;
            

            DataSourceResult result = busfuncs.ToDataSourceResult(request, bus => new BusFunc
            {
                ID = bus.ID,
                Name = bus.Name,
                Code = bus.Code,
                LocalizedTitle = bus.LocalizedTitle,
                DsbTileCssClass = bus.DsbTileCssClass,
                TechFuncID = bus.TechFuncID,
                IsCombo = bus.IsCombo,
                FleetOnly = bus.FleetOnly,
                Comment = bus.Comment
            });
            CreateToDatabase.DataSourceclose(dbe);
            return result;
        }
        public static DataSourceResult GetBusParOfBusFuncModels([DataSourceRequest]DataSourceRequest request)
        {
            var dbe = CreateToDatabase.DataSourceopen();
            IQueryable<BusParOfBusFunc> busparofbusfuncs = dbe.BusParOfBusFuncs;
           
            DataSourceResult result = busparofbusfuncs.ToDataSourceResult(request, par => new BusParOfBusFunc
            {
                ID = par.ID,
                BusFuncID = par.BusFuncID,
                BusParID = par.BusParID,
                Value_MaxCount = par.Value_MaxCount,
                Value_DateInterval_From = par.Value_DateInterval_From,
                Value_DateInterval_To = par.Value_DateInterval_To,
                Value_FeatureOption = par.Value_FeatureOption,
                Comment = par.Comment,
                BusPar = new BusPar
                {
                    ValueType = par.BusPar.ValueType,
                }
            });
            CreateToDatabase.DataSourceclose(dbe);
            return result;
        }
        public static void DestroyBusFuncModel(BusFunc bus)
        {
            
            DestroyFromDatabase.BusFuncDelete(BusFuncModel(bus));
        }
        
        public static void UpdateBusFuncModel(BusFunc bus)
        {
           
            UpdateInDatabase.BusFuncUpdate(BusFuncModel(bus));
        }
        public static BusFunc BusFuncModel (BusFunc bus)
        {
            var entity = new BusFunc
            {
                ID = bus.ID,
                Name = bus.Name,
                Code = bus.Code,
                LocalizedTitle = bus.LocalizedTitle,
                DsbTileCssClass = bus.DsbTileCssClass,
                TechFuncID = bus.TechFuncID,
                IsCombo = bus.IsCombo,
                FleetOnly = bus.FleetOnly,
                Comment = bus.Comment

            };
            return entity;
        }
    }
}
