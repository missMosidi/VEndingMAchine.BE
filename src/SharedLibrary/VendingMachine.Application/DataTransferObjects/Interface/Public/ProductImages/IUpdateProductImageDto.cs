using MediatR;
using RVendingMachine.Application.DataTransferObjects.Interface.Audited;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.ProductImages;
using VendingMachine.Application.DataTransferObjects.Interface.Common;
using VendingMachine.Domain.Models.Interfaces.Public;

namespace VendingMachine.Application.DataTransferObjects.Interface.Public.ProductImages
{
    public interface IUpdateProductImageDto : IRequest<ProductImageDto>, IProductImage, IHasModificationUserDto, IHasStatusIdDto
    {
    }
}
