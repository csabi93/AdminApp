using DAL.Models;

namespace DAL
{
    public class DestroyFromDatabase
    {
        public static void BusFuncDelete(BusFunc entity)
        {
            using (var dbe = new DAL.Model1())
            {
                dbe.BusFuncs.Attach(entity);
                dbe.BusFuncs.Remove(entity);
                dbe.SaveChanges();
            }
        }
        public static void TechFuncDelete(TechFunc entity)
        {
            using (var dbe = new Model1()) { 
            dbe.TechFuncs.Attach(entity);
            dbe.TechFuncs.Remove(entity);
            dbe.SaveChanges();
            }
        }
        public static void BusParDelete(BusPar entity)
        {
            using (var dbe = new Model1())
            {
                dbe.BusPars.Attach(entity);
                dbe.BusPars.Remove(entity);
                dbe.SaveChanges();
            }
        }
        public static void BusParOfBusFuncDelete(BusParOfBusFunc entity)
        {
            using (var dbe = new Model1())
            {
                dbe.BusParOfBusFuncs.Attach(entity);
                dbe.BusParOfBusFuncs.Remove(entity);
                dbe.SaveChanges();
            }
        }
    }
}