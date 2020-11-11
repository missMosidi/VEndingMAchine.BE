using MediatR;
using System.Collections.Generic;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.Sales;
using VendingMachine.Application.DataTransferObjects.Interface.Common;

namespace VendingMachine.Application.DataTransferObjects.Interface.Public.Sales
{
    public interface IGetSaleByStatusIdDto : IRequest<List<DetailedSaleDto>>, IHasStatusIdDto
    {
    }
}
