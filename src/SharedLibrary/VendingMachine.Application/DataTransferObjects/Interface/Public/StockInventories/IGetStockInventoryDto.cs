using MediatR;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.StockInventories;

namespace VendingMachine.Application.DataTransferObjects.Interface.Public.StockInventories
{
    public interface IGetStockInventoryDto : IRequest<StockInventoryDto>
    {
    }
}
