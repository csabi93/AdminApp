
using System.Linq;
using DAL.Models;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;

namespace DAL.BusPars
{
    public class BusParMethod
    {
        public static BusPar CreateBusParModel(BusPar bus)
        {
           
            CreateToDatabase.DbCreate(BusParModel(bus));
            return BusParModel(bus);
        }
        public static BusPar DestroyBusParModel(BusPar bus)
        {
            
            DestroyFromDatabase.BusParDelete(BusParModel(bus));
            return BusParModel(bus);
        }

        public static DataSourceResult HierarchyBusParDataSource(int id, DataSourceRequest req)
        {
            using (var dbe = new Model1())
            {
                IQueryable<BusPar> pars = dbe.BusPars;
                pars = pars.Where(order => order.ID == id);
                DataSourceResult result = pars.ToDataSourceResult(req, par => new BusPar
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
        public static BusPar BusParModelUpdate(BusPar bus)
            {
               
                UpdateInDatabase.BusParUpdate(BusParModel(bus));
                return BusParModel(bus);
            }
        public static IQueryable<BusPar> get_BusPar()
        {
            IQueryable<BusPar> busp = CreateToDatabase.DataSourceopen().BusPars;
            return busp;

        }
        public static BusPar BusParModel(BusPar bus)
        {
            var entity = new BusPar
            {
                ID = bus.ID,
                Code = bus.Code,
                ValueType = bus.ValueType,
                Comment = bus.Comment,
                Name = bus.Name

            };
            return entity;
        }
    }
       

}