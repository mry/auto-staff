using HMW.Core.Notifications.Absence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HMW.Core.Handlers
{
    class AvailableWorkHandler : INotificationHandler<AvailableWork>
    {
        public Task Handle(AvailableWork notification, CancellationToken cancellationToken)
        {
            // TODO

            return Task.FromResult(0);
        }
    }
}
