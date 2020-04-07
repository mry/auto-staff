using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HMW.Core;
using HMW.Core.Interfaces;
using HMW.Core.Models;
using HMW.Core.Requests.Organization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HMW.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrganizationController : ControllerBase
    {
        private readonly ILogger<OrganizationController> _logger;
        private readonly IDispatcher dispatcher;

        public OrganizationController(ILogger<OrganizationController> logger,IDispatcher dispatcher)
        {
            _logger = logger;
            this.dispatcher = dispatcher;
        }

        [HttpGet]
        public Task<IList<Organization>> Get()
        {
            return dispatcher.Send(new GetOrganizations());
        }

        [HttpPost]
        public void Save(CreateOrganization request)
        {
            dispatcher.Dispatch(request);
        }

        [HttpPost("/organization/{id}/location")]
        public void SaveLocation(CreateLocation request)
        {
            dispatcher.Dispatch(request);
        }


    }
}
