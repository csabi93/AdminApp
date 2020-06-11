

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BLL.ViewModels
{
    public class BusFuncViewModel
    {
        [ScaffoldColumn(false)]
        public int ID { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        public string Comment { get; set; }
        public string LocalizedTitle { get; set; }
        [ForeignKey("TechFuncID")]
        [UIHint("GridForeignKey")]
        [Required]
        [Display(Name = "TechFunc_Code")]
        public int TechFuncID { get; set; }

        public string DsbTileCssClass { get; set; }
        public bool IsCombo { get; set; }
        public bool FleetOnly { get; set; }
    }
}