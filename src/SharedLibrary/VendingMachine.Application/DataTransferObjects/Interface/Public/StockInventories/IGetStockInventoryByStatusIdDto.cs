using MediatR;
using System.Collections.Generic;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.StockInventories;
using VendingMachine.Application.DataTransferObjects.Interface.Common;

namespace VendingMachine.Application.DataTransferObjects.Interface.Public.StockInventories
{
    public interface IGetStockInventoryByStatusIdDto : IRequest<List<DetailedStockInventoryDto>>, IHasStatusIdDto
    {
    }
}
