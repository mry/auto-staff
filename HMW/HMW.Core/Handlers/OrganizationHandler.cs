using HMW.Core.Interfaces;
using HMW.Core.Models;
using HMW.Core.Requests.Organization;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HMW.Core.Handlers
{
    public class OrganizationHandler : IRequestHandler<CreateLocation>,
                                       IRequestHandler<CreateOrganization>,
                                       IRequestHandler<GetOrganizations, IList<Models.Organization>>
    {
        private readonly IOrganizationRepo organizationRepo;
        private readonly ILocationRepo locationRepo;

        public OrganizationHandler(IOrganizationRepo organizationRepo, ILocationRepo locationRepo)
        {
            this.organizationRepo = organizationRepo;
            this.locationRepo = locationRepo;
        }


        public Task<Unit> Handle(CreateLocation request, CancellationToken cancellationToken)
        {
            locationRepo.Save(new Location() { 
                OrganizationId = request.OrganizationId,
                Name = request.Name,
                Address = request.Address,
                Telephone = request.Telephone
            });

            return Task.FromResult(new Unit());
        }

        public Task<Unit> Handle(CreateOrganization request, CancellationToken cancellationToken)
        {
            organizationRepo.Save(new Organization()
            {
                Name = request.Name
            });

            return Task.FromResult(new Unit());
        }

        public Task<IList<Organization>> Handle(GetOrganizations request, CancellationToken cancellationToken)
        {
            return Task.FromResult(organizationRepo.GetAll());
        }
    }
}
