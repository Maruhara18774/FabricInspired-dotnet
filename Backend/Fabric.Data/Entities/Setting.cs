using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric.Data.Entities
{
    public class Setting : BaseAttribute
    {
        public string? SettingType { get; set; }
        public string? Value1 { get; set; }
        public string? Value2 { get; set; }
    }
}
