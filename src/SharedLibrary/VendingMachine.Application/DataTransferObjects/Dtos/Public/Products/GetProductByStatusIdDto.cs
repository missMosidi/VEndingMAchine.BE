using System;
using VendingMachine.Application.DataTransferObjects.Interface.Public.Products;

namespace VendingMachine.Application.DataTransferObjects.Dtos.Public.Products
{
    public class GetProductByStatusIdDto : IGetProductByStatusIdDto
    {
        public long? StatusId { get; set; }
    }
}
