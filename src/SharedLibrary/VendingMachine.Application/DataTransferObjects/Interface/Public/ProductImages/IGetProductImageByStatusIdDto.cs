using MediatR;
using System.Collections.Generic;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.ProductImages;
using VendingMachine.Application.DataTransferObjects.Interface.Common;

namespace VendingMachine.Application.DataTransferObjects.Interface.Public.ProductImages
{
    public interface IGetProductImageByStatusIdDto : IRequest<List<DetailedProductImageDto>>, IHasStatusIdDto
    {
    }
}
