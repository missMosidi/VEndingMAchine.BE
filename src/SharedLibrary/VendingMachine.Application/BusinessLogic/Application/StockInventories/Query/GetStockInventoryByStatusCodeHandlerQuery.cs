using AutoMapper;
using VendingMachine.Application.BaseHandler;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.StockInventories;
using VendingMachine.Domain.Models.Models.Public;
using VendingMachine.Persistance.EntityFramework.Context;

namespace VendingMachine.Application.BusinessLogic.Application.StockInventories.Query
{
    public class GetStockInventoryByStatusCodeHandlerQuery : BaseGetByStatusCodeRequestHandler<StockInventory, DetailedStockInventoryDto, GetStockInventoryByStatusCodeDto, VendingMachineDbContext>
    {
        public GetStockInventoryByStatusCodeHandlerQuery(VendingMachineDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
