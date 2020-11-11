using VendingMachine.Application.DataTransferObjects.Interface.Common;
using VendingMachine.Domain.Models.Interfaces.Public;

namespace VendingMachine.Application.DataTransferObjects.Interface.Public.StockInventories
{
    public interface IStockInventoryDto : IStockInventory, IHasStatusDto, IHasProductDto
    {
    }
}
