using MediatR;
using System.Collections.Generic;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.Sales;
using VendingMachine.Application.DataTransferObjects.Interface.Common;

namespace VendingMachine.Application.DataTransferObjects.Interface.Publict.Sales
{
    public interface IGetSaleByStatusCodeDto : IRequest<List<DetailedSaleDto>>, IHasStatusCode
    {
    }
}
