using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric.Data.Entities
{
    public class Image: BaseAttribute
    {
        public int ProductID { get; set; }
        public string? Url { get; set;}

        public virtual Product? Product { get; set; }
    }
}
