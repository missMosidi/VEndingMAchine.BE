using MediatR;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.ProductImages;

namespace VendingMachine.Application.DataTransferObjects.Interface.Public.ProductImages
{
    public interface IGetProductImageDto : IRequest<ProductImageDto>
    {
    }
}
