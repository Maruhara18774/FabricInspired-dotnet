using Fabric.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric.Data.Entities
{
    public class Product: BaseAttribute
    {
        public string? Name { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public double Width { get; set; }
        public WeightEnum Weight { get; set; }
        public StretchEnum Stretch { get; set; }
        public string? WovedIn { get; set; }
        public string? PatternID { get; set; }
        public string? CategoryID { get; set; }
        public string? Description { get; set; }

        public virtual Pattern?  Pattern { get; set; }
        public virtual Category? Category { get; set;}
        public virtual List<Image>? Images { get; set; }
        public virtual List<Sale>? Sales { get; set; }
        public virtual List<Moonboard>? Moonboards { get; set; }
        public virtual List<OrderDetail>? OrderDetails { get; set; }

    }
}
