using AutoMapper;
using VendingMachine.Application.BaseHandler;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.Statuses;
using VendingMachine.Domain.Models.Models.Public;
using VendingMachine.Persistance.EntityFramework.Context;

namespace VendingMachine.Application.BusinessLogic.Application.Statuses.Command
{
    public class UpdateStatusHandlerCommand : BaseUpdateRequestHandler<Status, StatusDto, UpdateStatusDto, VendingMachineDbContext>
    {
        public UpdateStatusHandlerCommand(VendingMachineDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
