using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Weaselware.Knoodle.Data.Models
{
    public class Assembly
    {
        public Assembly()
        {
            Width = 0.0m;
            Height = 0.0m;
            Depth = 0.0m;
            AssemblyName = string.Empty;
        }

       
        public int AssemblyID { get; set; }
        public int ProductionGroupID { get; set; }
        public string AssemblyName { get; set; }
        public string ArchRef { get; set; }
        public DateTime ProductionDate { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public decimal Depth { get; set; }
        public decimal Perimeter()
        {
            decimal result = 0.0m;
            result = (Width * 2) + (Height * 2);
            return result;
        }


        public decimal Area()
        {
            decimal result = 0.0m;
            result = Width * Height;
            return result;
        }



        // Costing Properties ----------------------------------------

        public decimal CalculatedCost { get; set; }
        public decimal LaborHours { get; set; }
        public string ProductionID { get; set; }
        public bool IsContracted { get; set; }


        public ICollection<SubAssembly> SubAssemblies {get; set; }
    }
}
