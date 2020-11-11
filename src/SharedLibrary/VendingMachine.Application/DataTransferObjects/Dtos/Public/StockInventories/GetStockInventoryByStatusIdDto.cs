using System;
using VendingMachine.Application.DataTransferObjects.Interface.Public.StockInventories;

namespace VendingMachine.Application.DataTransferObjects.Dtos.Public.StockInventories
{
    public class GetStockInventoryByStatusIdDto : IGetStockInventoryByStatusIdDto
    {
        public long? StatusId { get; set; }
    }
}
