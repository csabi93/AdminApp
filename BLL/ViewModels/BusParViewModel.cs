
using System.ComponentModel.DataAnnotations;

namespace BLL.ViewModels
{
   public  class BusParViewModel
    {
        [ScaffoldColumn(false)]
        public int ID { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        public string Comment { get; set; }
        [Required]
        [Range(0, 3, ErrorMessage = "A ValueType mezőnek 1 és 3 között kell hogy legyen")]
        public byte ValueType { get; set; }

    }
}
