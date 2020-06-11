
using System.Linq;
using DAL.Models;
using Kendo.Mvc.UI;

namespace DAL.TechFuncs
{
    public class TechFuncMethod
    {
        public static TechFunc CreateTechFuncModel(TechFunc tech)
        {
          
            CreateToDatabase.DbCreate(TechFuncModel(tech));
            return TechFuncModel(tech);
        }

        public static TechFunc DestroyTechFuncModel(TechFunc tech)
        {
            
            DestroyFromDatabase.TechFuncDelete(TechFuncModel(tech));
            return TechFuncModel(tech);
        }
        
        public static TechFunc UpdateTechFuncModel(TechFunc tech)
        {
          
            UpdateInDatabase.TechFuncUpdate(TechFuncModel(tech));
            return TechFuncModel(tech);
        }
       public static IQueryable<TechFunc> TechFuncByID (int id, [DataSourceRequest]DataSourceRequest request)
        {
            var dbe = new Model1();
            
                IQueryable<TechFunc> techs = dbe.TechFuncs;
                techs = techs.Where(order => order.ID == id);
                return techs;
            
        }
        public static IQueryable<TechFunc> getTechFuncs([DataSourceRequest]DataSourceRequest request)
        {
            CreateToDatabase.DataSourceopen();
            IQueryable<TechFunc> techs = CreateToDatabase.DataSourceopen().TechFuncs;
            return techs;

        }
        public static IQueryable<TechFunc> getTechFuncs()
        {
            CreateToDatabase.DataSourceopen();
            IQueryable<TechFunc> techs = CreateToDatabase.DataSourceopen().TechFuncs;
            return techs;

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
    }
}