using System;
using VendingMachine.Application.DataTransferObjects.Interface.Public.Sales;

namespace VendingMachine.Application.DataTransferObjects.Dtos.Public.Sales
{
    public class GetSaleByStatusIdDto : IGetSaleByStatusIdDto
    {
        public long? StatusId { get; set; }
    }
}
