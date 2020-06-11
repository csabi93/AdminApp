using DAL.Models;
using System.Linq;

namespace DAL.BusParOfBusFuncs
{
    public class BusParOfBusFuncMethod
    {
        public static BusParOfBusFunc CreateBusParOfBusFuncModel(BusParOfBusFunc par)
        {          
           
            CreateToDatabase.DbCreate(BusParOfBusFuncModel(par));
            return BusParOfBusFuncModel(par);
        }
        public static void DestroyBusParOfBusFuncModel(BusParOfBusFunc par)
        { 
            DestroyFromDatabase.BusParOfBusFuncDelete(BusParOfBusFuncModel(par));
        }
        public static void UpdateBusParOfBusFuncModel(BusParOfBusFunc par)
        {       
            UpdateInDatabase.BusParOfBusFuncUpdate(BusParOfBusFuncModel(par));
        }
        public static IQueryable<BusParOfBusFunc> getBusParOfBusFuncs()
        {
            IQueryable<BusParOfBusFunc> bparfunc = CreateToDatabase.DataSourceopen().BusParOfBusFuncs;
            return bparfunc;

        }
        public static BusParOfBusFunc BusParOfBusFuncModel (BusParOfBusFunc par)
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