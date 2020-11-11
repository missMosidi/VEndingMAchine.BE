using MediatR;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.Sales;

namespace VendingMachine.Application.DataTransferObjects.Interface.Public.Sales
{
    public interface IGetSaleDto : IRequest<SaleDto>
    {
    }
}
