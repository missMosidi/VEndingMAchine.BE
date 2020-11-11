using System;
using VendingMachine.Application.DataTransferObjects.Dtos.Common;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.Products;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.Statuses;
using VendingMachine.Application.DataTransferObjects.Interface.Public.Sales;

namespace VendingMachine.Application.DataTransferObjects.Dtos.Public.Sales
{
    public class DetailedSaleDto : EntityDto<Guid>, IDetailedSaleDto
    {
        public int Quantity { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Change { get; set; }
        public StatusDto Status { get; set; }
        public DateTime? CreationTime { get; set; }
        public ProductDto Product { get; set; }
    }
}
