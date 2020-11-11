using MediatR;
using RVendingMachine.Application.DataTransferObjects.Interface.Audited;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.Products;
using VendingMachine.Application.DataTransferObjects.Interface.Common;
using VendingMachine.Domain.Models.Interfaces.Public;

namespace VendingMachine.Application.DataTransferObjects.Interface.Public.Products
{
    public interface IUpdateProductDto : IRequest<ProductDto>, IProduct, IHasStatusIdDto, IHasProductImageIdDto, IHasModificationUserDto
    {
    }
}
