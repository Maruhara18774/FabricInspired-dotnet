using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric.Data.Entities
{
    public class Sale: BaseAttribute
    {
        public string? ProductID { get; set; }
        public double Price { get; set; }

        public virtual Product? Product { get; set; }
    }
}
