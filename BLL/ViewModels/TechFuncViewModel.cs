
using System.ComponentModel.DataAnnotations;

namespace BLL.ViewModels
{
    public class TechFuncViewModel
    {
        [ScaffoldColumn(false)]
        public int ID { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string Title { get; set; }
        public string Comment { get; set; }

    }
}
