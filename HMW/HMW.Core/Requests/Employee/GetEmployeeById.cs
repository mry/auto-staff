﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMW.Core.Requests.Employee
{
    public class GetEmployeeById : IRequest<Models.Employee>
    {
        public string Id { get; set; }
    }
}
