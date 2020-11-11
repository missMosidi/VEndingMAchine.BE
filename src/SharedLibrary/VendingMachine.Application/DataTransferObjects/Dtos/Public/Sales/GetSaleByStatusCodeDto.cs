using VendingMachine.Application.DataTransferObjects.Interface.Publict.Sales;
using VendingMachine.Domain.Models.Enums;

namespace VendingMachine.Application.DataTransferObjects.Dtos.Public.Sales
{
    public class GetSaleByStatusCodeDto : IGetSaleByStatusCodeDto
    {
        public StatusCode StatusCode { get; set; }
    }
}
