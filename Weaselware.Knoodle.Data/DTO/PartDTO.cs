using System;
using System.Collections.Generic;
using System.Text;

namespace Weaselware.Knoodle.Data.DTO
{
    public class PartDTO
    {
        public PartDTO()
        {

        }

        public int PartID { get; set; }
        public string PartName { get; set; }
        public decimal W { get; set; }
        public decimal H { get; set; }
        public decimal L { get; set; }

    }
}
