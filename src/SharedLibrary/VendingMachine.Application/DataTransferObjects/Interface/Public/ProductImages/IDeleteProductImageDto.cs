using MediatR;
using RVendingMachine.Application.DataTransferObjects.Interface.Audited;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.ProductImages;
using VendingMachine.Domain.Models.Models.Public;

namespace VendingMachine.Application.DataTransferObjects.Interface.Public.ProductImages
{
    public interface IDeleteProductImageDto : IRequest<ProductImageDto>, IHasDeletionUserDto
    {
    }
}
