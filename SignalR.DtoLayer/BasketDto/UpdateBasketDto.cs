using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.BasketDto
{
    public class UpdateBasketDto
    {
        [Key]
        public int BasketId { get; set; }

        public decimal Price { get; set; }
        public int Count { get; set; }
        public decimal TotalPrice { get; set; }
        public int MenuTableId { get; set; }
        public int ProductId { get; set; }
    }
}
