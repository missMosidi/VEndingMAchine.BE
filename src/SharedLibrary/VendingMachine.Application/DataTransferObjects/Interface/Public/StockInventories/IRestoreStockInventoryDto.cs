using MediatR;
using RVendingMachine.Application.DataTransferObjects.Interface.Audited;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.StockInventories;

namespace VendingMachine.Application.DataTransferObjects.Interface.Public.StockInventories
{
    public interface IRestoreStockInventoryDto : IRequest<StockInventoryDto>, IHasModificationUserDto
    {
    }
}
