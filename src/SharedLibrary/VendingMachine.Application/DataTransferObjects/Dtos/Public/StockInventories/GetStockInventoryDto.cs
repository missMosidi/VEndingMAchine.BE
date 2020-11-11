using System;
using VendingMachine.Application.DataTransferObjects.Dtos.Common;
using VendingMachine.Application.DataTransferObjects.Interface.Public.StockInventories;

namespace VendingMachine.Application.DataTransferObjects.Dtos.Public.StockInventories
{
    public class GetStockInventoryDto : InputBaseEntityDto<Guid>, IGetStockInventoryDto
    {
    }
}
