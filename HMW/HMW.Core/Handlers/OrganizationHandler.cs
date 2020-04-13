using HMW.Core.Interfaces;
using HMW.Core.Models;
using HMW.Core.Requests.Organization;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HMW.Core.Handlers
{
    public class OrganizationHandler : IRequestHandler<CreateLocation>,
                                       IRequestHandler<UpdateLocation>,
                                       IRequestHandler<CreateOrganization>,
                                       IRequestHandler<GetOrganizations, IList<Models.Organization>>
    {
        private readonly IOrganizationRepo organizationRepo;

        public OrganizationHandler(IOrganizationRepo organizationRepo)
        {
            this.organizationRepo = organizationRepo;
        }


        public Task<Unit> Handle(CreateLocation request, CancellationToken cancellationToken)
        {
            var org = organizationRepo.Get(request.OrganizationId);
            if (org.Locations.Any(x => x.Name.Equals(request.Name)))
            {
                throw new Exception("Location already exists");
            }

            organizationRepo.SaveLocation(request.OrganizationId, new Location()
            {
                Name = request.Name,
                Address = request.Address,
                Telephone = request.Telephone,
                Id = Guid.NewGuid().ToString(),
                Created = DateTime.Now
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

        public Task<Unit> Handle(UpdateLocation request, CancellationToken cancellationToken) {

            var org = organizationRepo.Get(request.OrganizationId);
            if (!org.Locations.Any(x => x.Id.Equals(request.Id)))
            {
                throw new Exception("Location does not exists");
            }

            organizationRepo.UpdateLocation(request.OrganizationId, new Location()
            {
                Name = request.Name,
                Address = request.Address,
                Telephone = request.Telephone,
                Id = request.Id
            });

            return Task.FromResult(new Unit());
        }
    }
}
