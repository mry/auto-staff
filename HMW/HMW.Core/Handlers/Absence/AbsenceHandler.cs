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
    class AbsenceHandler : INotificationHandler<CreateAbsence>
    {
        private readonly IOrganizationRepo organizationRepo;
        private readonly IEmployeeRepo employeeRepo;
        private readonly ILocationRepo locationRepo;
        private readonly IDispatcher dispatcher;

        public AbsenceHandler(IOrganizationRepo organizationRepo, IEmployeeRepo employeeRepo, ILocationRepo locationRepo, IDispatcher dispatcher)
        {
            this.organizationRepo = organizationRepo;
            this.employeeRepo = employeeRepo;
            this.locationRepo = locationRepo;
            this.dispatcher = dispatcher;
        }

        public Task Handle(CreateAbsence notification, CancellationToken cancellationToken)
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

            var location = locationRepo.Get(notification.LocationId);
            if (location == null)
            {
                throw new Exception("No location found");
            }

            // spawn new AvailableWorkNotification
            dispatcher.Dispatch(new AvailableWork()
            {
                EmployeeId = notification.EmployeeId,
                EmployeeName = $"{employee.Firstname} {employee.Lastname}",
                End = notification.End,
                LocationId = notification.LocationId,
                LocationName = location.Name,
                Note = notification.Note,
                OrganizationId = employee.OrganizationId,
                Start = notification.Start
            });

            // TODO:
            // get HR-endpoint for this organization and send absence notification

            return Task.FromResult(0);
        }
    }
}
