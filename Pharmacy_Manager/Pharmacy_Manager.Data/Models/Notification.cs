using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Manager.Data.Models
{
    public class Notification
    {

        public Notification()
        {
            LowStock = 0;
            ToExpire = 0;
        }
        public int ID { get; set; }
        public int LowStock { get; set; }
        public int ToExpire { get; set; }
    }
}
