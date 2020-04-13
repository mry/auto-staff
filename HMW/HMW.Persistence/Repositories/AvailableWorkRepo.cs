using HMW.Core.Interfaces;
using HMW.Core.Models;

namespace HMW.Persistence.Repositories
{
    public class AvailableWorkRepo : MongoCollectionBase<AvailableWork>, IAvailableWorkRepo
    {
        public AvailableWorkRepo(IDbConfig dbConfig) : base(dbConfig, "AvailableWork")  {  }
    }
}
