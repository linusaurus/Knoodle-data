using System;
using System.Collections.Generic;
using System.Text;

namespace Weaselware.Knoodle.Data.Models
{
    public class WorkCenter
    {
        public int WorkCenterID { get; set; }
        public string WorkCenterName { get; set; }
        public decimal? CostRate { get; set; }
        public decimal? Availabilty { get; set; }
    }

    public class WorkOrder
    {
        public int WorkOrderID { get; set; }
        public int ProjectID { get; set; }
        public DateTime? WorkOrderDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }

    public class WorkOrderRouting
    {
        public int WorkOrderID { get; set; }
        public int? ProductID { get; set; }
        public int? OperationSequence { get; set; }
        public int? LocationID { get; set; }
        public DateTime? ScheduledStartDate { get; set; }
        public DateTime? ScheduledEndDate { get; set; }
        public DateTime? ActualStartDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public decimal? PlannedCost { get; set; }
        public decimal? ActualCost { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? EmployeeID { get; set; }
        public int? TaskID { get; set; }
    }

}
