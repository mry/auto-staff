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
        private readonly IAvailableWorkPublisher availableWorkPublisher;

        public AvailableWorkHandler(IAvailableWorkRepo availableWorkRepo, IEmployeeRepo employeeRepo, IAvailableWorkPublisher availableWorkPublisher)
        {
            this.availableWorkRepo = availableWorkRepo;
            this.employeeRepo = employeeRepo;
            this.availableWorkPublisher = availableWorkPublisher;
        }

         public async Task Handle(AvailableWorkNotification notification, CancellationToken cancellationToken)
        {
            var availableWork = new AvailableWork()
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
            };

            // save to repo
            availableWorkRepo.Save(availableWork);

            // send to publisher
            await availableWorkPublisher.PublishAsync(availableWork);

        }
    }
}
