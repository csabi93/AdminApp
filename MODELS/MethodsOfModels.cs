using Kendo.Mvc.UI;
using DAL.Models;
using System.Linq;
using Kendo.Mvc.Extensions;

namespace MODELS
{
    public class MethodsOfModels
    {
        public static DataSourceResult TechFuncDataSource(DataSourceRequest reg)
        {
            using (var dbe = new WE2Dashboard_dev_ErpCntEntities())
            {
                IQueryable<TechFunc> techs = dbe.TechFuncs;
                DataSourceResult result = techs.ToDataSourceResult(reg, tech => new TechFunc
                {
                    ID = tech.ID,
                    Code = tech.Code,
                    Title = tech.Title,
                    Comment = tech.Comment
                });
                return result;
            } 
        }

        public static DataSourceResult HierarchyTechFuncDataSource(DataSourceRequest reg, int id)
        {
            using (var dbe = new WE2Dashboard_dev_ErpCntEntities())
            {
                IQueryable<TechFunc> techs = dbe.TechFuncs;
                techs = techs.Where(order => order.ID == id);
                DataSourceResult result = techs.ToDataSourceResult(reg, tech => new TechFunc
                {
                    ID = tech.ID,
                    Code = tech.Code,
                    Title = tech.Title,
                    Comment = tech.Comment
                });
                return result;
            }
        }

        public static DataSourceResult BusFuncDataSource(DataSourceRequest reg)
        {
            using (var dbe = new WE2Dashboard_dev_ErpCntEntities())
            {
                IQueryable<BusFunc> busfuncs = dbe.BusFuncs;
                DataSourceResult result = busfuncs.ToDataSourceResult(reg, busfunc => new BusFunc
                {
                    ID = busfunc.ID,
                    Name = busfunc.Name,
                    Code = busfunc.Code,
                    LocalizedTitle = busfunc.LocalizedTitle,
                    DsbLargeTile = busfunc.DsbLargeTile,
                    DsbSmallTile = busfunc.DsbSmallTile,
                    DsbMediumTile = busfunc.DsbMediumTile,
                    DsbTileCssClass = busfunc.DsbTileCssClass,
                    TechFuncID = busfunc.TechFuncID,
                    IsCombo = busfunc.IsCombo,
                    FleetOnly = busfunc.FleetOnly,
                    Comment=busfunc.Comment
                });
                return result;
            }
        }

        public static DataSourceResult BusParDataSource(DataSourceRequest reg)
        {
            using (var dbe = new WE2Dashboard_dev_ErpCntEntities())
            {
                IQueryable<BusPar> buspars = dbe.BusPars;
                DataSourceResult result = buspars.ToDataSourceResult(reg, par => new BusPar
                {
                    ID = par.ID,
                    Code = par.Code,
                    ValueType = par.ValueType,
                    Comment = par.Comment,
                    Name = par.Name
                });
                return result;
            }
        }

        public static DataSourceResult BusParOfBusFuncDataSource(DataSourceRequest reg)
        {
            using (var dbe = new WE2Dashboard_dev_ErpCntEntities())
            {
                IQueryable<BusParOfBusFunc> busparofbusfuncs = dbe.BusParOfBusFuncs;
                DataSourceResult result = busparofbusfuncs.ToDataSourceResult(reg, par => new BusParOfBusFunc
                {
                    ID = par.ID,
                    BusFuncID = par.BusFuncID,
                    BusParID = par.BusParID,
                    Value_MaxCount = par.Value_MaxCount,
                    Value_DateInterval_From = par.Value_DateInterval_From,
                    Value_DateInterval_To = par.Value_DateInterval_To,
                    Value_FeatureOption = par.Value_FeatureOption,
                    Comment = par.Comment
                });
                return result;
            }
        }

        public static BusPar BusParModel(BusPar bus)
        {
            var entity = new BusPar
            {
                ID = bus.ID,
                Code = bus.Code,
                ValueType = bus.ValueType,
                Comment = bus.Comment,
                Name=bus.Name

            };
            return entity;
        }
        public static BusFunc BusFuncModel(BusFunc bus)
        {
            var entity = new BusFunc
            {
                ID = bus.ID,
                Name = bus.Name,
                Code = bus.Code,
                LocalizedTitle = bus.LocalizedTitle,
                DsbLargeTile = bus.DsbLargeTile,
                DsbSmallTile = bus.DsbSmallTile,
                DsbMediumTile = bus.DsbMediumTile,
                DsbTileCssClass = bus.DsbTileCssClass,
                TechFuncID = bus.TechFuncID,
                IsCombo = bus.IsCombo,
                FleetOnly = bus.FleetOnly,
                Comment=bus.Comment

            };
            return entity;
        }
        public static TechFunc TechFuncModel(TechFunc tech)
        {
            var entity = new TechFunc
            {
                ID = tech.ID,
                Code = tech.Code,
                Title = tech.Title,
                Comment = tech.Comment

            };
            return entity;
        }

        public static BusParOfBusFunc BusParIfBusFuncModel(BusParOfBusFunc par)
        {
            var entity = new BusParOfBusFunc
            {
                ID = par.ID,
                Value_MaxCount = par.Value_MaxCount,
                Value_DateInterval_From = par.Value_DateInterval_From,
                Value_DateInterval_To = par.Value_DateInterval_To,
                Value_FeatureOption = par.Value_FeatureOption,
                Comment = par.Comment,
                BusParID = par.BusParID,
                BusFuncID = par.BusFuncID

            };
            return entity;
        }

    }
}
