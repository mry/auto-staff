using HMW.Core.Interfaces;
using HMW.Core.Notifications;
using HMW.Core.Requests.Absence;
using HMW.Core.Validators;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HMW.Core.Handlers.Absence
{
    class AbsenceHandler : IRequestHandler<CreateAbsence>
    {
        private readonly IAbsenceValidator absenceValidator;
        private readonly IDispatcher dispatcher;

        public AbsenceHandler(IAbsenceValidator absenceValidator, IDispatcher dispatcher)
        {
            this.absenceValidator = absenceValidator;
            this.dispatcher = dispatcher;
        }

        public Task<Unit> Handle(CreateAbsence request, CancellationToken cancellationToken)
        {
            var result = absenceValidator.ValidateCreate(request);
            if (!result.IsValid)
            {
                throw new Exception(result.Message);
            }

            // TODO:
            // No need to persist Absence IMO.
            // 1. Get HR-endpoint for this organization and send absence notification
            // 2. Create and dispatch AvailableWork notification

            // 3.
            dispatcher.Dispatch(new AvailableWorkNotification()
            {
                EmployeeId = request.EmployeeId,
                EmployeeName = $"{result.Employee.Firstname} {result.Employee.Lastname}",
                End = request.End,
                LocationId = request.LocationId,
                LocationName = result.Location.Name,
                Note = request.Note,
                OrganizationId = result.Employee.OrganizationId,
                Start = request.Start
            });

            return Task.FromResult(new Unit());
        }
    }
}
