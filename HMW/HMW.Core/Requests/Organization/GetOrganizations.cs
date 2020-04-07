using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMW.Core.Requests.Organization
{
    public class GetOrganizations : IRequest<IList<Models.Organization>>
    {
        
    }
}
