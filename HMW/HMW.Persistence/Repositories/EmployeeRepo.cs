using HMW.Core.Interfaces;
using HMW.Core.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;

namespace HMW.Persistence.Repositories
{
    public class EmployeeRepo : MongoCollectionBase<Employee>, IEmployeeRepo
    {
        private const string COLLECTION_NAME = "Employee";
        public EmployeeRepo(IDbConfig dbconfig) : base(dbconfig, COLLECTION_NAME)  {  }

        public IList<Employee> GetByOrganizationId(string id)
        {
            return collection.Find(x => x.OrganizationId.Equals(id)).ToList();
        }

        public void UpdateAvailableForWork(string id, bool available)
        {
            var update = Builders<Employee>.Update.Set(x => x.AvailableForWork, available);
            collection.UpdateOne((x => x.Id.Equals(id)), update);
        }

        public IList<Employee> GetAvailableForWork(IList<string> organizationIds)
        {
            return collection.Find(x => x.AvailableForWork && organizationIds.Contains(x.OrganizationId)).ToList();
        }
    }
}
