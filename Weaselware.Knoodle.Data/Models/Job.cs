using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Weaselware.Knoodle.Data.Models
{
    public class Job
    {
        [Key]
        public int Job_id { get; set; }
        public string JobName { get; set; }
        public string jobDesc { get; set; }

        public ICollection<ProductionGroup> ProductionGroup { get; set; } = new HashSet<ProductionGroup>();
    }
}
