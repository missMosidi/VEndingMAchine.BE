using AutoMapper;
using VendingMachine.Application.BaseHandler;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.StockInventories;
using VendingMachine.Domain.Models.Models.Public;
using VendingMachine.Persistance.EntityFramework.Context;

namespace VendingMachine.Application.BusinessLogic.Application.StockInventories.Query
{
    public class GetStockInventoryHandlerQuery : BaseGetRequestHandler<StockInventory, StockInventoryDto, GetStockInventoryDto, VendingMachineDbContext>
    {
        public GetStockInventoryHandlerQuery(VendingMachineDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
