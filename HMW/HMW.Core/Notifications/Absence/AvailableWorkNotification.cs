using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMW.Core.Notifications.Absence
{
    public class AvailableWorkNotification : INotification
    {
        public string EmployeeId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string LocationId { get; set; }
        public string Note { get; set; }
        public string OrganizationId { get; set; }
        public string LocationName { get; set; }

    }
}
