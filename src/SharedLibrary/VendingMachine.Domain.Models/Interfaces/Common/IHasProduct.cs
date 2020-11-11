using VendingMachine.Domain.Models.Models.Public;

namespace VendingMachine.Domain.Models.Interfaces.Common
{
    public interface  IHasProduct
    {
        Product Product { get; set; }
    }
}
