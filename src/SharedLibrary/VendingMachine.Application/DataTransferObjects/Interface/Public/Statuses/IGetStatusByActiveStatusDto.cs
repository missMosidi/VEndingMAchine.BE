using MediatR;
using RVendingMachine.Application.DataTransferObjects.Interface.Audited;
using System.Collections.Generic;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.Statuses;

namespace VendingMachine.Application.DataTransferObjects.Interface.Public.Statuses
{
    public interface IGetStatusByActiveStatusDto : IRequest<List<DetailedStatusDto>>, IHasActiveStatusDto
    {
    }
}
