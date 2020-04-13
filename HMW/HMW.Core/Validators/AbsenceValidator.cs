using HMW.Core.Interfaces;
using HMW.Core.Requests.Absence;
using System.Linq;

namespace HMW.Core.Validators
{
    public class AbsenceValidator : IAbsenceValidator
    {
        private readonly IOrganizationRepo organizationRepo;
        private readonly IEmployeeRepo employeeRepo;

        public AbsenceValidator(IOrganizationRepo organizationRepo, IEmployeeRepo employeeRepo)
        {
            this.organizationRepo = organizationRepo;
            this.employeeRepo = employeeRepo;
        }

        public CreateAbsenceValidationResult ValidateCreate(CreateAbsence createAbsence)
        {
            bool isValid = true;
            string message = null;

            var employee = employeeRepo.Get(createAbsence.EmployeeId);
            if (employee == null)
            {
                message = "No employee found";
                isValid = false;
            }

            var org = organizationRepo.Get(employee.OrganizationId);
            if (org == null)
            {
                message = "No organization found";
                isValid = false;
            }

            var location = org.Locations.SingleOrDefault(x => x.Id.Equals(createAbsence.LocationId));
            if (location == null)
            {
                message = "No location found";
                isValid = false;
            }

            return new CreateAbsenceValidationResult()
            {
                IsValid = isValid,
                Message = message,
                Employee = employee,
                Organization = org,
                Location = location
            };
        }
    }
}
