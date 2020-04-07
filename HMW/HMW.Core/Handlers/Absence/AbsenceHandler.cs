using HMW.Core.Interfaces;
using HMW.Core.Notifications.Absence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HMW.Core.Handlers.Absence
{
    class AbsenceHandler : INotificationHandler<CreateAbsenceNotification>
    {
        private readonly IOrganizationRepo organizationRepo;
        private readonly IEmployeeRepo employeeRepo;

        public AbsenceHandler(IOrganizationRepo organizationRepo, IEmployeeRepo employeeRepo)
        {
            this.organizationRepo = organizationRepo;
            this.employeeRepo = employeeRepo;
        }

        public Task Handle(CreateAbsenceNotification notification, CancellationToken cancellationToken)
        {
            var employee = employeeRepo.Get(notification.EmployeeId);
            if (employee == null)
            {
                throw new Exception("No employee found");
            }

            var org = organizationRepo.Get(employee.OrganizationId);
            if (org == null)
            {
                throw new Exception("No organization found");
            }



            // TODO:
            // get HR-endpoint for this organization and send absence notification

            return Task.FromResult(0);
        }
    }
}
