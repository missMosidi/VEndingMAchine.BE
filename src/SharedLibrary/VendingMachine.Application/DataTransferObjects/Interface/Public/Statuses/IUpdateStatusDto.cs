using MediatR;
using RVendingMachine.Application.DataTransferObjects.Interface.Audited;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.Statuses;
using VendingMachine.Domain.Models.Interfaces.Public;

namespace VendingMachine.Application.DataTransferObjects.DataTransferObjects.Interface.Public.Statuses
{
    public interface IUpdateStatusDto : IRequest<StatusDto>, IStatus, IHasActiveStatusDto
    {
    }
}
