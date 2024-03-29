﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Manager.Data.Models.PurchaseModel
{
    public class Purchase
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Invoice No")]
        public int ID { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        [Display(Name = "Supplier")]
        public int SupplierID { get; set; }
        public decimal Amount { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Tax { get; set; }
        [Required]
        public decimal GrandTotal { get; set; }
        public bool IsPaid { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string Description { get; set; }


        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<PurchaseItem> PurchaseItems { get; set; }
    }
}
