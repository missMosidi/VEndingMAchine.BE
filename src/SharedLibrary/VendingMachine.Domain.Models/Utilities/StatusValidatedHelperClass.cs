using VendingMachine.Domain.Models.Enums;

namespace VendingMachine.Domain.Models.Utilities
{
    public static class StatusValidatedHelperClass
    {
        public static bool ValiodateVisablity(StatusCode input) =>
            input == StatusCode.Published ||
            input == StatusCode.Active ||
            input == StatusCode.Complete ||
            input == StatusCode.Approved;
    }
}
