using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Weaselware.Knoodle.Data.Models
{
    public class SubAssembly
    {
        [Key]
        public string SubAssemblyID { get; set; }
        public string SubAssemblyName { get; set; }
        public int AssemblyID { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public decimal Depth { get; set; }
        public string MakeFile { get; set; }
        // Statistics---------------------------------

        public decimal Perimeter { get; set; }
        public decimal Area { get; set; }
        public decimal Weight { get; set; }
        public decimal CompositeCost { get; set; }
        public decimal LaborHr { get; set; }

        // Energy Report Parameters------------------
        public string UnitType { get; set; }
        public int GlassID {get;set;}
        public string SystemName { get; set; }
        public string FrameSashType { get; set; }
        public int CPD_ID { get; set; }

        //Parts Collection
        public ICollection<ComponentPart> ComponentParts { get; set; } = new HashSet<ComponentPart>();

    }
}
