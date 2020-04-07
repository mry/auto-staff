using HMW.Core.Interfaces;
using HMW.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMW.Persistence.Repositories
{
    public class LocationRepo : MongoCollectionBase<Location>, ILocationRepo
    {
        private const string COLLECTION_NAME = "Locations";
        public LocationRepo(IDbConfig dbConfig) : base(dbConfig, COLLECTION_NAME) { }
    }
}
