﻿using HMW.Core.Models;
using System.Collections.Generic;

namespace HMW.Core.Interfaces
{
    public interface IEmployeeRepo
    {
        IList<Employee> GetAll();
        IList<Employee> GetByOrganizationId(string id);
        Employee Get(string id);
        void Save(Employee employee);
        void Update(Employee employee);
        void UpdateAvailableForWork(string id, bool available);
        IList<Employee> GetAvailableForWork(IList<string> organizationIds);
    }
}
