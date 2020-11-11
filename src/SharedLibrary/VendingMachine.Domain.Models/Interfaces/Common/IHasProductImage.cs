using VendingMachine.Domain.Models.Models.Public;

namespace VendingMachine.Domain.Models.Interfaces.Common
{
    public interface IHasProductImage
    {
        ProductImage ProductImage { get; set; }
    }
}
