using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric.Data.Entities
{
    public class Category: BaseAttribute
    {
        public string? Name { get; set; }
        public string? Description { get; set; }

        public virtual List<ProductCategory>? ProductCategories { get; set; }
    }
}
