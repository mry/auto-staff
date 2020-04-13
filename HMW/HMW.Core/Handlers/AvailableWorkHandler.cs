using HMW.Core.Interfaces;
using HMW.Core.Models;
using HMW.Core.Notifications;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace HMW.Core.Handlers
{
    class AvailableWorkHandler :INotificationHandler<AvailableWorkNotification>
    {
        private readonly IAvailableWorkRepo availableWorkRepo;
        private readonly IEmployeeRepo employeeRepo;

        public AvailableWorkHandler(IAvailableWorkRepo availableWorkRepo, IEmployeeRepo employeeRepo)
        {
            this.availableWorkRepo = availableWorkRepo;
            this.employeeRepo = employeeRepo;
        }

         public Task Handle(AvailableWorkNotification notification, CancellationToken cancellationToken)
        {
            // save to repo
            availableWorkRepo.Save(new AvailableWork()
            {
                AbsentEmployeeId = notification.EmployeeId,
                Created = DateTime.Now,
                EmployeeName = notification.EmployeeName,
                End = notification.End,
                LocationId = notification.LocationId,
                LocationName = notification.LocationName,
                Note = notification.Note,
                OrganizationId = notification.OrganizationId,
                Start = notification.Start
            });

            // get available workers to notify
            var workers = employeeRepo.GetAvailableForWork(new List<string>() { notification.OrganizationId });

            return Task.FromResult(0);
        }
    }
}
