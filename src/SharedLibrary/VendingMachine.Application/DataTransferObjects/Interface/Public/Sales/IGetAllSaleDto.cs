using MediatR;
using System.Collections.Generic;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.Sales;

namespace VendingMachine.Application.DataTransferObjects.Interface.Public.Sales
{
    public interface IGetAllSaleDto : IRequest<List<SaleDto>>
    {
    }
}
