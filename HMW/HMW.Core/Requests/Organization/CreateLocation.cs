using HMW.Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMW.Core.Requests.Organization
{
    public class CreateLocation : IRequest
    {
        public string OrganizationId { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public string Telephone { get; set; }
    }
}
