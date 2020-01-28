using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Manager.Data.Models.InventoryModel
{
    public class Manufacturer
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Too lengthy")]
        public String ManufacturerName { get; set; }
        public string Description { get; set; }


        // public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}
