using MediatR;
using System.Collections.Generic;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.Products;
using VendingMachine.Application.DataTransferObjects.Interface.Common;

namespace VendingMachine.Application.DataTransferObjects.Interface.Public.Products
{
    public interface IGetProductByStatusIdDto : IRequest<List<DetailedProductDto>>, IHasStatusIdDto
    {
    }
}
