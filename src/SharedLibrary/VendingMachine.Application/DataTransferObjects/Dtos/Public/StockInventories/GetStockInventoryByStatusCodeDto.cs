using VendingMachine.Application.DataTransferObjects.Interface.Public.StockInventories;
using VendingMachine.Domain.Models.Enums;

namespace VendingMachine.Application.DataTransferObjects.Dtos.Public.StockInventories
{
    public class GetStockInventoryByStatusCodeDto : IGetStockInventoryByStatusCodeDto
    {
        public StatusCode StatusCode { get; set; }
    }
}
