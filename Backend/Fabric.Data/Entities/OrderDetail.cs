using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric.Data.Entities
{
    public class OrderDetail: BaseAttribute
    {
        public string? OrderID { get; set; }
        public string? ProductID { get; set; }
        public double Metre { get; set; }
        public double Total { get; set; }

        public virtual Order? Order { get; set; }
        public virtual Product? Product { get; set; }
    }
}
