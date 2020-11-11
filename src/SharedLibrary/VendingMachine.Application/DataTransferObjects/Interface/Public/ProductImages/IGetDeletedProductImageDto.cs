using MediatR;
using System.Collections.Generic;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.ProductImages;

namespace VendingMachine.Application.DataTransferObjects.Interface.Public.ProductImages
{
    public interface IGetDeletedProductImageDto : IRequest<List<DetailedProductImageDto>>
    {
    }
}
