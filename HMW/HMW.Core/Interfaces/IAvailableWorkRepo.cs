using HMW.Core.Models;
using System.Collections.Generic;

namespace HMW.Core.Interfaces
{
    public interface IAvailableWorkRepo
    {
        IList<AvailableWork> GetAll();
        AvailableWork Get(string id);
        void Save(AvailableWork availablework);
    }
}