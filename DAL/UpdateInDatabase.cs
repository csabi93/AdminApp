
using System.Data.Entity;
using DAL.Models;
namespace DAL

{
    public class UpdateInDatabase
    {
        public static void BusFuncUpdate(BusFunc entity)
        {
            using (var dbe = new Model1())
            {
                dbe.BusFuncs.Attach(entity);
                dbe.Entry(entity).State = EntityState.Modified;
                dbe.SaveChanges();
            }
        }
        public static void BusParUpdate(BusPar entity)
        {
            using (var dbe = new Model1())
            {
                dbe.BusPars.Attach(entity);
                dbe.Entry(entity).State = EntityState.Modified;
                dbe.SaveChanges();
            }
        }
        public static void BusParOfBusFuncUpdate(BusParOfBusFunc entity)
        {
            using (var dbe = new Model1())
            {
                dbe.BusParOfBusFuncs.Attach(entity);
                dbe.Entry(entity).State = EntityState.Modified;
                dbe.SaveChanges();
            }
        }
        public static void TechFuncUpdate(TechFunc entity)
        {
            using (var dbe = new Model1())
            {
                dbe.TechFuncs.Attach(entity);
                dbe.Entry(entity).State = EntityState.Modified;
                dbe.SaveChanges();
            }
        }
    }
}