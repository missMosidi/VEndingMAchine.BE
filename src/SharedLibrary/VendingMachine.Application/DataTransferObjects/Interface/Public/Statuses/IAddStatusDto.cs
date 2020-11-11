using MediatR;
using RVendingMachine.Application.DataTransferObjects.Interface.Audited;
using VendingMachine.Domain.Models.Interfaces.Public;

namespace VendingMachine.Application.DataTransferObjects.DataTransferObjects.Interface.Public.Statuses
{
    public interface IAddStatusDto: IRequest, IStatus, IHasActiveStatusDto
    {

    }
}
