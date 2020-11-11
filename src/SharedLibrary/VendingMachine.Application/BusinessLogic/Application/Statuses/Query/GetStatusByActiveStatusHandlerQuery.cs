using AutoMapper;
using VendingMachine.Application.BaseHandler;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.Statuses;
using VendingMachine.Domain.Models.Models.Public;
using VendingMachine.Persistance.EntityFramework.Context;

namespace VendingMachine.Application.BusinessLogic.Application.Statuses.Query
{
    public class GetStatusByActiveStatusHandlerQuery : BaseGetByActiveStatusRequestHandler<Status, DetailedStatusDto, GetStatusByActiveStatusDto, VendingMachineDbContext>
    {
        public GetStatusByActiveStatusHandlerQuery(VendingMachineDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
