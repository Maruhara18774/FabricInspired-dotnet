using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric.Data.Entities
{
    public class User: IdentityUser<Guid>
    {
        public virtual List<Moonboard>? Moonboards { get; set; }
        public virtual List<Order>? Orders { get; set; }
    }
}
