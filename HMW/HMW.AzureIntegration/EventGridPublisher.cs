using HMW.Core.Interfaces;
using HMW.Core.Models;
using Microsoft.Azure.EventGrid;
using Microsoft.Azure.EventGrid.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HMW.AzureIntegration
{
    public class EventGridPublisher : IAvailableWorkPublisher
    {
        private readonly IEventPublisherConfig config;

        public EventGridPublisher(IEventPublisherConfig config)
        {
            this.config = config;
        }

        public async Task PublishAsync(AvailableWork availableWork)
        {
            string topicHostname = new Uri(config.Endpoint).Host;
            var topicCredentials = new TopicCredentials(config.Key);
            var client = new EventGridClient(topicCredentials);

            var t = client.PublishEventsAsync(topicHostname, new List<EventGridEvent>()
            {
                new EventGridEvent()
                {
                    Data = availableWork,
                    DataVersion = "1.0",
                    EventTime = DateTime.Now,
                    EventType = "AvailableWork.Created",
                    Id = Guid.NewGuid().ToString(),
                    Subject = "AvailableWork"
                }
            });

            await t;

            var x = "kalle";
        }
    }
}
