using HMW.Core.Interfaces;
using HMW.Core.Models;
using MongoDB.Driver;
using System.Linq;

namespace HMW.Persistence.Repositories
{
    public class OrganizationRepo : MongoCollectionBase<Organization>, IOrganizationRepo
    {
        private const string COLLECTION_NAME = "Organizations";

        public OrganizationRepo(IDbConfig dbconfig) : base(dbconfig, COLLECTION_NAME) { }

        public void SaveLocation(string id, Location location)
        {
            var update = Builders<Organization>.Update.AddToSet(x => x.Locations, location);
            collection.UpdateOne((x => x.Id.Equals(id)), update);
        }

        public void UpdateLocation(string id, Location location)
        {
            var update = Builders<Organization>.Update.Set(x => x.Locations[-1], location); // -1 means; update first matching element in array
            collection.UpdateOne(x => x.Id.Equals(id) && x.Locations.Any(y => y.Id.Equals(location.Id)), update);
        }
    }
}
