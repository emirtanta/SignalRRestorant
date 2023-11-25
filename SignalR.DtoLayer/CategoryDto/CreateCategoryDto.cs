using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.CategoryDto
{
    public class CreateCategoryDto
    {

        [StringLength(50)]
        [Display(Name = "Kategori Adı")]
        public string CategoryName { get; set; }

        [Display(Name = "Durum")]
        public bool? Status { get; set; }
    }
}
