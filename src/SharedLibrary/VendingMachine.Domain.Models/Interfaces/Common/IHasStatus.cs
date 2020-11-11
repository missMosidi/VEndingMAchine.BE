using VendingMachine.Domain.Models.Models.Public;

namespace VendingMachine.Domain.Models.Interfaces.Common
{
    public interface IHasStatus
    {
        Status Status { get; set; }
    }
}
