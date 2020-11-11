using MediatR;
using System.Collections.Generic;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.ProductImages;
using VendingMachine.Application.DataTransferObjects.Interface.Common;

namespace VendingMachine.Application.DataTransferObjects.Interface.Public.ProductImages
{
    public interface IGetProductImageByStatusCodeDto : IRequest<List<DetailedProductImageDto>>, IHasStatusCode
    {
    }
}
