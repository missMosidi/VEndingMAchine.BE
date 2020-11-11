using System;
using VendingMachine.Application.DataTransferObjects.Dtos.Common;
using VendingMachine.Application.DataTransferObjects.Interface.Public.StockInventories;

namespace VendingMachine.Application.DataTransferObjects.Dtos.Public.StockInventories
{
    public class RestoreStockInventoryDto : InputBaseEntityDto<Guid>, IRestoreStockInventoryDto
    {
        [System.Text.Json.Serialization.JsonIgnore, Newtonsoft.Json.JsonIgnore]
        public Guid? LastModifierUserId { get; set; }
    }
}
