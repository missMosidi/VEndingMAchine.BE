using System;
using VendingMachine.Application.DataTransferObjects.Interface.Public.ProductImages;

namespace VendingMachine.Application.DataTransferObjects.Dtos.Public.ProductImages
{
    public class GetProductImageByStatusIdDto : IGetProductImageByStatusIdDto
    {
        public long? StatusId { get; set; }
    }
}
