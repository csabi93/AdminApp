
using DAL.Models;

namespace DAL
{
    public class CreateToDatabase
    {
       public static Model1 dbe = new Model1();
        public static void  DbCreate( BusFunc entity)
        {
            var dbe = new Model1();
            dbe.BusFuncs.Add(entity);
            dbe.SaveChanges();
        }
        public static void DbCreate(BusPar entity)
        {
            var dbe = new Model1();
            dbe.BusPars.Add(entity);
            dbe.SaveChanges();
        }
    
        public static void DbCreate(TechFunc entity)
        {
            var dbe = new Model1();
            dbe.TechFuncs.Add(entity);
            dbe.SaveChanges();
        }
        public static void DbCreate(BusParOfBusFunc entity)
        {
            var dbe = new Model1();
            dbe.BusParOfBusFuncs.Add(entity);
            dbe.SaveChanges();
        }
        public static Model1 DataSourceopen()
        {
            var dbe = new Model1();
            return dbe;
            
        }
        public static void DataSourceclose(Model1 db)
        {
            db.Dispose();
        }
    }
}