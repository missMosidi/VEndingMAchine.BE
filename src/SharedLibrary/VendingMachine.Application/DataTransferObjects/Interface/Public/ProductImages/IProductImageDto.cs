using VendingMachine.Application.DataTransferObjects.Dtos.Common;
using VendingMachine.Application.DataTransferObjects.Interface.Common;
using VendingMachine.Domain.Models.Interfaces.Public;

namespace VendingMachine.Application.DataTransferObjects.Interface.Public.ProductImages
{
    public interface IProductImageDto: IProductImage, IHasStatusDto
    {
    }
}
