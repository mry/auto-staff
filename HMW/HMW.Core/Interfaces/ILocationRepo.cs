using HMW.Core.Models;
using System.Collections.Generic;

namespace HMW.Core.Interfaces
{
    public interface ILocationRepo
    {
        IList<Location> GetAll();
        Location Get(string id);
        void Save(Location location);
    }
}