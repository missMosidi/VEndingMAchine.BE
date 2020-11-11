using AutoMapper;
using VendingMachine.Application.BaseHandler;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.Statuses;
using VendingMachine.Domain.Models.Models.Public;
using VendingMachine.Persistance.EntityFramework.Context;

namespace VendingMachine.Application.BusinessLogic.Application.Statuses.Query
{
    public class GetDeletedStatusHandlerQuery : BaseGetDeletedRequestHandler<Status, DetailedStatusDto, GetDeletedStatusDto, VendingMachineDbContext>
    {
        public GetDeletedStatusHandlerQuery(VendingMachineDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
