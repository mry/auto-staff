using HMW.Core.Requests.Absence;

namespace HMW.Core.Validators
{
    public interface IAbsenceValidator
    {
        CreateAbsenceValidationResult ValidateCreate(CreateAbsence createAbsence);
    }
}