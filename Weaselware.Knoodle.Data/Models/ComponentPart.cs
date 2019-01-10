using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Weaselware.Knoodle.Data.Models
{
    public class ComponentPart
    {
        [Key]
        public int PartID { get; set; }
        public string PartName { get; set; }
        public int SubAssemblyID { get; set; }
        public int PartGroup { get; set; }
        public decimal W { get; set; }
        public decimal H { get; set; }
        public decimal D { get; set; }
    }
}
