using AutoMapper;
using VendingMachine.Application.BaseHandler;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.StockInventories;
using VendingMachine.Domain.Models.Models.Public;
using VendingMachine.Persistance.EntityFramework.Context;

namespace VendingMachine.Application.BusinessLogic.Application.StockInventories.Command
{
    public class RestoreStockInventoryHandlerCommand : BaseRestoreRequestHandler<StockInventory, StockInventoryDto, RestoreStockInventoryDto, VendingMachineDbContext>
    {
        public RestoreStockInventoryHandlerCommand(VendingMachineDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
