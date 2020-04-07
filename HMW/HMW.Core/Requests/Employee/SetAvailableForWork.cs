using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMW.Core.Requests.Employee
{
    public class SetAvailableForWork : IRequest
    {
        public bool Available { get; set; }
        public string EmployeeId { get; set; }
    }
}
