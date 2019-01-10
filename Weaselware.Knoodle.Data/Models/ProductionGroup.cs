using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Weaselware.Knoodle.Data.Models
{
    public class ProductionGroup
    {
     [Key]
     public int ProductionGroupID { get; set; }
     public string ProductionGroupName { get; set; }
     public int JobID { get; set; }
	 public DateTime Created { get; set; }
	 public bool IsVisible { get; set; }
	 public bool IsContracted { get; set; }

     public ICollection<Assembly> Assemblies { get; set; } = new HashSet<Assembly>();

    }
}
