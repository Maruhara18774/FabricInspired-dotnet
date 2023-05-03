using Fabric.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric.Data.Entities
{
    public class Order: BaseAttribute
    {
        public Guid UserID { get; set; }
        public OrderStatusEnum State { get; set; }
        public double Total { get; set; }

        public virtual User? User { get; set; }
        public virtual List<OrderDetail>? OrderDetails { get; set; }
    }
}
