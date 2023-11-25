using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.EntityLayer.Entities
{
    public class MenuTable
    {
        [Key]
        public int MenuTableId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
        public bool Status { get; set; }

        //MenuTable ile Basket arasındaki 1'e çok ilişki
        public List<Basket> Baskets { get; set; }
    }
}
