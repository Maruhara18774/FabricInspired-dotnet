using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric.Data.Entities
{
    public class BaseAttribute
    {
        public string? ID { get; set; }
        public bool Active { get; set; } = true;
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Updated { get; set; } = DateTime.Now;
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set;}
    }
}
