using System;
using VendingMachine.Application.DataTransferObjects.Dtos.Common;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.Products;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.Statuses;
using VendingMachine.Application.DataTransferObjects.Interface.Public.StockInventories;

namespace VendingMachine.Application.DataTransferObjects.Dtos.Public.StockInventories
{
    public class DetailedStockInventoryDto : EntityDto<Guid>, IDetailedStockInventoryDto
    {
        public int TotalItems { get; set; }
        public bool IsOutOfStock { get; set; }
        public StatusDto Status { get; set; }
        public Guid? CreatorUserId { get; set; }
        public DateTime? CreationTime { get; set; }
        public Guid? LastModifierUserId { get; set; }
        public DateTime? ModicationTime { get; set; }
        public Guid? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public bool IsDeleted { get; set; }
        public ProductDto Product { get; set; }
    }
}
