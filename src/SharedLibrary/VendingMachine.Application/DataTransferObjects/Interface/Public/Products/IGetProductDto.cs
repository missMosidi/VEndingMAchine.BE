using MediatR;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.Products;

namespace VendingMachine.Application.DataTransferObjects.Interface.Public.Products
{
    public interface IGetProductDto : IRequest<ProductDto>
    {
    }
}
