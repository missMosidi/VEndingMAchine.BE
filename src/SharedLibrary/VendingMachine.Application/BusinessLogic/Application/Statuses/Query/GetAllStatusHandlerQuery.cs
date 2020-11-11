using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using VendingMachine.Application.BaseHandler;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.Statuses;
using VendingMachine.Domain.Models.Models.Public;
using VendingMachine.Persistance.EntityFramework.Context;

namespace VendingMachine.Application.BusinessLogic.Application.Statuses.Query
{
    public class GetAllStatusHandlerQuery : BaseGetAllRequestHandler<Status, StatusDto, GetAllStatusDto, VendingMachineDbContext>
    {
        public GetAllStatusHandlerQuery(VendingMachineDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override async Task<List<StatusDto>> Handle(GetAllStatusDto request, CancellationToken cancellationToken)
        {
            var entityData = (await this._context
                    .Set<Status>()
                    .ToListAsync(cancellationToken))
                    .Where(x => x.IsDeleted == false && x.ActiveStatus == true)
                    .ToList();

            return this._mapper.Map<List<Status>, List<StatusDto>>(entityData);
        }
    }
}
