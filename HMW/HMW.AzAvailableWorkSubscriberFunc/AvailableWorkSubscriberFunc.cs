// Default URL for triggering event grid function in the local environment.
// http://localhost:7071/runtime/webhooks/EventGrid?functionName={functionname}
using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Azure.EventGrid.Models;
using Microsoft.Azure.WebJobs.Extensions.EventGrid;
using Microsoft.Extensions.Logging;
using HMW.Core.Models;
using HMW.Persistence.Repositories;
using HMW.Core.Interfaces;
using HMW.Core.Config;
using System.Collections.Generic;

namespace HMW.AzAvailableWorkSubscriberFunc
{
    public static class AvailableWorkSubscriberFunc
    {
        [FunctionName("AvailableWorkSubscriberFunc")]
        public static void Run([EventGridTrigger]EventGridEvent eventGridEvent, ILogger log)
        {
            log.LogInformation(eventGridEvent.Data.ToString());

            if (eventGridEvent.Data is AvailableWork)
            {
                // get available workers from db and send information
                // use same Organization at first. Later we should expand functionality to use organizations and their Locations coords to get an accurate area, set by the user.

                var avwork = (AvailableWork)eventGridEvent.Data;

                IDbConfig dbConfig = new DbConfig()
                {
                    ConnectionString = ""
                };

                var db = new EmployeeRepo(dbConfig);

                var employees = db.GetAvailableForWork(new string[] { avwork.OrganizationId });

                // TODO : make async and better performance.
                // Add preferredContactType to Employee so we can use that here.

                foreach(var e in employees)
                {
                    // hmm.. what other ways of contacting a employee, besided mobile phone (SMS), do we have ?
                    // If the user is online on an app, we could use Signalr or similar tech to give them a push notification.
                    
                }
                
            }
        }
    }
}
