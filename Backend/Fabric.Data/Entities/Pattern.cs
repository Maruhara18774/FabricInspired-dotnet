﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric.Data.Entities
{
    public class Pattern: BaseAttribute
    {
        public string? Name { get; set; }
        public virtual List<Product>? Products { get; set; }
    }
}
