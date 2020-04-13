using HMW.Core.Models;

namespace HMW.Core.Validators
{
    public class CreateAbsenceValidationResult
    {
        public string Message { get; internal set; }
        public bool IsValid { get; internal set; }
        public Employee Employee { get; internal set; }
        public Organization Organization { get; internal set; }
        public Location Location { get; internal set; }
    }
}