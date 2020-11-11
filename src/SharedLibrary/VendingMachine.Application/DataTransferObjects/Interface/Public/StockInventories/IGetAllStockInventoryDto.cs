using MediatR;
using System.Collections.Generic;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.StockInventories;

namespace VendingMachine.Application.DataTransferObjects.Interface.Public.StockInventories
{
    public interface IGetAllStockInventoryDto : IRequest<List<StockInventoryDto>>
    {
    }
}
