using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using VendingMachine.Application.BaseHandler;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.Statuses;
using VendingMachine.Domain.Models.Models.Public;
using VendingMachine.Persistance.EntityFramework.Context;

namespace VendingMachine.Application.BusinessLogic.Application.Statuses.Query
{
    public class GetStatusesHandlerQuery : BaseGetRequestHandler<Status, StatusDto, GetStatusDto, VendingMachineDbContext>
    {
        public GetStatusesHandlerQuery(VendingMachineDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override async Task<StatusDto> Handle(GetStatusDto request, CancellationToken cancellationToken)
        {
            var entityData = (await this._context
                    .Set<Status>()
                    .ToListAsync())
                    .Where(x => x.IsDeleted == false && x.ActiveStatus == true)
                    .FirstOrDefault();

            return this._mapper.Map<StatusDto>(entityData);
        }
    }
}
