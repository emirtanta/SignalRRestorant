using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.EntityLayer.Entities
{
    //Kasa tablosu
    public class MoneyCase
    {
        [Key]
        public int MoneyCaseId { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
