using MediatR;
using RVendingMachine.Application.DataTransferObjects.Interface.Audited;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.ProductImages;

namespace VendingMachine.Application.DataTransferObjects.Interface.Public.ProductImages
{
    public interface IRestoreProductImageDto : IRequest<ProductImageDto>, IHasModificationUserDto
    {
    }
}
