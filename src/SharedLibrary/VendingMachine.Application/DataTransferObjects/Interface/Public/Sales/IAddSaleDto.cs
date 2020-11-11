using MediatR;
using VendingMachine.Application.DataTransferObjects.Interface.Common;
using VendingMachine.Domain.Models.Interfaces.Public;

namespace VendingMachine.Application.DataTransferObjects.Interface.Public.Sales
{
    public interface IAddSaleDto : IRequest, ISale, IHasStatusIdDto, IHasProductIdDto
    {
    }
}
