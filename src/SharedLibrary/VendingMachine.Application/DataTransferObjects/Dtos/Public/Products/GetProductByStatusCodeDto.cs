using VendingMachine.Application.DataTransferObjects.Interface.Public.Products;
using VendingMachine.Domain.Models.Enums;

namespace VendingMachine.Application.DataTransferObjects.Dtos.Public.Products
{
    public class GetProductByStatusCodeDto : IGetProductByStatusCodeDto
    {
        public StatusCode StatusCode { get; set; }
    }
}
