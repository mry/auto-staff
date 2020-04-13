using System;
using System.Collections.Generic;
using System.Text;

namespace HMW.Core.Models
{
    public class AvailableWork : ModelBase
    {
        public string AbsentEmployeeId { get; set; }
        public string EmployeeName { get; internal set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string LocationId { get; set; }
        public string Note { get; set; }
        public string OrganizationId { get; set; }
        public string LocationName { get; set; }
        
    }
}
