
using System.Collections.Generic;
using System.Linq;
using DAL.BusParOfBusFuncs;
using DAL.BusFuncs;
using Kendo.Mvc.UI;
using DAL.Models;
using BLL.ViewModels;
using Kendo.Mvc.Extensions;
using BLL.BusParServices;
using BLL.BusFuncServices;
using DAL.BusPars;

namespace BLL.BusParOfBusFuncServices
{
    public class BusParOfBusFuncservices
    {
        public static void DestroyBusParModel(BusParOfBusFuncViewModel bus)
        {
            BusParOfBusFuncMethod.DestroyBusParOfBusFuncModel(ConvertToBusParOfBusFunc(bus));
        }
        public static List<BusParViewModel> BusParPopulate()
        {
            return BusParservices.GetBusParWith_ID_And_Code();
        }

       
        public static int GetVal(int i)
        {
            List<BusParViewModel> result = new List<BusParViewModel>();  
            result = BusParMethod.get_BusPar().Select(bpar => new BusParViewModel
            {
                ID = bpar.ID,
                Code = bpar.Code,
                Name = bpar.Name,
                ValueType = bpar.ValueType

            }).ToList();
            return result.Find(x => x.ID == i).ValueType;
        }
        public static List<BusFuncViewModel> BusFuncPopulate()
        {
            
            return BusFuncservices.GetAllBusFuncsWithID_And_Code();
        }
        public static DataSourceResult GetBusParOfBusFuncsDatasource([DataSourceRequest]DataSourceRequest request)
        {
            return BusFuncMethod.GetBusParOfBusFuncModels(request);
        }

        public static byte CreateBusParOfBusFuncModel(BusParOfBusFuncViewModel product)
        {
            bool succes = true;
            byte Errstate = 0;    
            var first = GetAll().OrderByDescending(e => e.ID).FirstOrDefault();
            var id = (first != null) ? first.ID : 0;
                 
                if(product.Value_DateInterval_From>product.Value_DateInterval_To)
                {
                    succes = false;
                    Errstate = 4;
                }

                product.ID = id + 1;
                DAL.BusParOfBusFunc bpaar = ConvertToBusParOfBusFunc(product);

                if (succes == true)
                {
                    BusParOfBusFuncMethod.CreateBusParOfBusFuncModel(bpaar);
                    GetAll().Insert(0, product);
                }    
            return Errstate;
        }
        public static byte UpdateBusParOfBusFuncModel(BusParOfBusFuncViewModel bus)
        {
            bool succes = true;
            byte Errstate = 0;
           
            var first = GetAll().OrderByDescending(e => e.ID).FirstOrDefault();
            var id = (first != null) ? first.ID : 0;

           
            if (bus.Value_DateInterval_From > bus.Value_DateInterval_To)
            {
                succes = false;
                Errstate = 4;
            }
            if(succes==true)
                BusParOfBusFuncMethod.UpdateBusParOfBusFuncModel(ConvertToBusParOfBusFunc(bus));
            return Errstate;
        }
        public static List<BusParOfBusFuncViewModel> GetAll()
        {
            List<BusParOfBusFuncViewModel> result = new List<BusParOfBusFuncViewModel>();         
            result = BusParOfBusFuncMethod.getBusParOfBusFuncs().Select(bus => new BusParOfBusFuncViewModel
            {
                ID = bus.ID,
                BusParID = bus.BusParID,    
                BusFuncID = bus.BusFuncID,          
                Value_DateInterval_From = bus.Value_DateInterval_From,
                Value_DateInterval_To = bus.Value_DateInterval_To,
                Value_FeatureOption = bus.Value_FeatureOption,
                Comment = bus.Comment,
                Value_MaxCount = bus.Value_MaxCount

            }).ToList();
            return result;
        }
        public static DAL.BusParOfBusFunc ConvertToBusParOfBusFunc(BusParOfBusFuncViewModel bus)
        {
            DAL.BusParOfBusFunc b = new DAL.BusParOfBusFunc
            {
                ID = bus.ID,
                BusParID=bus.BusParID,
                BusFuncID=bus.BusFuncID,
                Value_DateInterval_From=bus.Value_DateInterval_From,
                Value_DateInterval_To=bus.Value_DateInterval_To,
                Value_FeatureOption=bus.Value_FeatureOption,
                Comment=bus.Comment,
                Value_MaxCount=bus.Value_MaxCount,       
            };
            return b;
        }
        
    }
}
