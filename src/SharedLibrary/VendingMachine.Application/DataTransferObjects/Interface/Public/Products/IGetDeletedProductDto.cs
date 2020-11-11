using MediatR;
using System.Collections.Generic;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.Products;

namespace VendingMachine.Application.DataTransferObjects.Interface.Public.Products
{
    public interface IGetDeletedProductDto : IRequest<List<DetailedProductDto>>
    {
    }
}
