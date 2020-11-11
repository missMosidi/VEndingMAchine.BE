using MediatR;
using RVendingMachine.Application.DataTransferObjects.Interface.Audited;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.Products;

namespace VendingMachine.Application.DataTransferObjects.Interface.Public.Products
{
    public interface IRestoreProductDto : IRequest<ProductDto>, IHasModificationUserDto
    {
    }
}
