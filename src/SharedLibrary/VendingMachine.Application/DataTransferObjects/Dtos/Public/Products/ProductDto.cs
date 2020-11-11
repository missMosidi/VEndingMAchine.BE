using System;
using VendingMachine.Application.DataTransferObjects.Dtos.Common;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.ProductImages;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.Statuses;
using VendingMachine.Application.DataTransferObjects.Interface.Public.Products;

namespace VendingMachine.Application.DataTransferObjects.Dtos.Public.Products
{
    public class ProductDto : EntityDto<Guid>, IProductDto
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }
        public StatusDto Status { get; set; }
        public ProductImageDto ProductImage { get; set; }
    }
}
