using Pharmacy_Manager.Data.Models.InventoryModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Manager.Data.Models.SalesModel
{
    public class SalesItem
    {
        [Key]
        public int ID { get; set; }
        public int StockID { get; set; }
        public int SalesID { get; set; }
        [Required]
        public int Qty { get; set; }
        [Required]
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }

        public virtual Stock Stock { get; set; }
        public virtual Sales Sales { get; set; }
    }
}
