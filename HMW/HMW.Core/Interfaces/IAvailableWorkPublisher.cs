using HMW.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HMW.Core.Interfaces
{
    public interface IAvailableWorkPublisher
    {
        Task PublishAsync(AvailableWork availableWork);
    }
}
