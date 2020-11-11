using MediatR;
using RVendingMachine.Application.DataTransferObjects.Interface.Audited;
using VendingMachine.Application.DataTransferObjects.Interface.Common;
using VendingMachine.Domain.Models.Interfaces.Public;

namespace VendingMachine.Application.DataTransferObjects.Interface.Public.StockInventories
{
    public interface IAddStockInventoryDto : IRequest, IStockInventory, IHasStatusIdDto, IHasProductIdDto, IHasCreationUserDto
    {
    }
}
