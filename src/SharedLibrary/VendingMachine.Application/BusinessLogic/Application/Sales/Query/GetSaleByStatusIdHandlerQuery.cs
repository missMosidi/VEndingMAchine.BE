using AutoMapper;
using VendingMachine.Application.BaseHandler;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.Sales;
using VendingMachine.Domain.Models.Models.Public;
using VendingMachine.Persistance.EntityFramework.Context;

namespace VendingMachine.Application.BusinessLogic.Application.Sales.Query
{
    public class GetSaleByStatusIdHandlerQuery : BaseGetByStatusIDRequestHandler<Sale, DetailedSaleDto, GetSaleByStatusIdDto, VendingMachineDbContext>
    {
        public GetSaleByStatusIdHandlerQuery(VendingMachineDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
