using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Weaselware.Knoodle.Data.Models
{
    public class Part
    {

       
        public int PartID { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public string PartNum { get; set; }
        public int? ManuID { get; set; }
        public bool? ObsoluteFlag { get; set; }
        public int? PartTypeID { get; set; }
        public decimal? Cost { get; set; }
        public int? UID { get; set; }
        public string Location { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Waste { get; set; }
        public decimal? MarkUp { get; set; }

        public string AddedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? ModifiedDate { get; set; }
        
        public string ManuPartNum { get; set; }
        public string SKU { get; set; }
    




    }
}
