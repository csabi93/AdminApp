

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BLL.ViewModels
{
   public  class BusParOfBusFuncViewModel
    {
        [ScaffoldColumn(false)]
        public int ID { get; set; }
        [ForeignKey("BusFuncID")]
        [UIHint("CustomPopUp")]
        [Display(Name = "BusFunc_Code")]
        public int BusFuncID { get; set; }
        [ForeignKey("BusParID")]
        [UIHint("CustomPopUp")]
        [Display(Name = "BusPar_Code")]
        public int BusParID { get; set; }
        public string Comment { get; set; }
        public Nullable<int> Value_MaxCount { get; set; }
        public Nullable<bool> Value_FeatureOption { get; set; }

        public Nullable<System.DateTime> Value_DateInterval_From { get; set; }
        [UIHint("CustomPopUp")]
        public Nullable<System.DateTime> Value_DateInterval_To { get; set; }
          
     
    }
}
