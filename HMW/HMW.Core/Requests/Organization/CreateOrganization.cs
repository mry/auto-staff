using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMW.Core.Requests.Organization
{
    public class CreateOrganization : IRequest
    {
        public string Name { get; set; }
    }
}
