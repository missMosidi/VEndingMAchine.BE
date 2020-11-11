using System;
using VendingMachine.Application.DataTransferObjects.Dtos.Common;
using VendingMachine.Application.DataTransferObjects.Interface.Public.ProductImages;

namespace VendingMachine.Application.DataTransferObjects.Dtos.Public.ProductImages
{
    public class GetProductImageDto : InputBaseEntityDto<Guid>, IGetProductImageDto
    {
    }
}
