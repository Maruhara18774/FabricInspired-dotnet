using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric.Data.Entities
{
    public class Moonboard: BaseAttribute
    {
        public Guid UserID { get; set; }
        public string? ProductID { get; set; }

        public virtual User? User { get; set; }
        public virtual Product? Product { get; set; }
    }
}
