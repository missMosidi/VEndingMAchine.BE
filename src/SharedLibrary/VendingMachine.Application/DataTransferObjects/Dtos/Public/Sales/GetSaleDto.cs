using System;
using VendingMachine.Application.DataTransferObjects.Dtos.Common;
using VendingMachine.Application.DataTransferObjects.Interface.Public.Sales;

namespace VendingMachine.Application.DataTransferObjects.Dtos.Public.Sales
{
    public class GetSaleDto : InputBaseEntityDto<Guid>, IGetSaleDto
    {
    }
}
