using Pharmacy_Manager.Data.Models.InventoryModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Manager.Data.Models.PurchaseModel
{
    public class PurchaseItem
    {
        public int ID { get; set; }
        public int PurchaseID { get; set; }
        public int ItemID { get; set; }
        public string Batch { get; set; }

        [Range(0, 1000000, ErrorMessage = "Not an acceptable Quantity!")]
        public int Qty { get; set; }

        [Range(0, 1000000, ErrorMessage = "Not an acceptable Quantity!")]
        public int? BonusIncluded { get; set; }

        [Range(0.00, 99999999.99)]
        public decimal CostPrice { get; set; }
        public decimal SellingPrice { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Expiry { get; set; }

        public virtual Item Item { get; set; }
        public virtual Purchase Purchase { get; set; }
    }
}
