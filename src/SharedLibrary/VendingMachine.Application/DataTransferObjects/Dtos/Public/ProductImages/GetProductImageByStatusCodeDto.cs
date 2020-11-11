using VendingMachine.Application.DataTransferObjects.Interface.Public.ProductImages;
using VendingMachine.Domain.Models.Enums;

namespace VendingMachine.Application.DataTransferObjects.Dtos.Public.ProductImages
{
    public class GetProductImageByStatusCodeDto : IGetProductImageByStatusCodeDto
    {
        public StatusCode StatusCode { get; set; }
    }
}
