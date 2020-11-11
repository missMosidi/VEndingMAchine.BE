using VendingMachine.Application.DataTransferObjects.Interface.Common;
using VendingMachine.Domain.Models.Interfaces.Public;

namespace VendingMachine.Application.DataTransferObjects.Interface.Public.Products
{
    public interface IProductDto : IProduct, IHasStatusDto, IHasProductImageDto
    {
    }
}
