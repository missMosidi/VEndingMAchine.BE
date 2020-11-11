using System;
using VendingMachine.Application.DataTransferObjects.Dtos.Common;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.Products;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.Statuses;
using VendingMachine.Application.DataTransferObjects.Interface.Public.StockInventories;

namespace VendingMachine.Application.DataTransferObjects.Dtos.Public.StockInventories
{
    public class StockInventoryDto : EntityDto<Guid>, IStockInventoryDto
    {
        public int TotalItems { get; set; }
        public bool IsOutOfStock { get; set; }
        public StatusDto Status { get; set; }
        public ProductDto Product { get; set; }
    }
}
