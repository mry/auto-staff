using HMW.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMW.Core.Config
{
    public class EventPublisherConfig : IEventPublisherConfig
    {
        public string Endpoint { get; set; }
        public string Key { get; set; }
    }
}
