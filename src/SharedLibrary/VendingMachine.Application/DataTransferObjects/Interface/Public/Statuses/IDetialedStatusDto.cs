using RVendingMachine.Application.DataTransferObjects.Interface.Audited;
using VendingMachine.Domain.Models.Interfaces.Public;

namespace VendingMachine.Application.DataTransferObjects.Interface.Public.Statuses
{
    public interface IDetialedStatusDto : IStatus, IHasCreationTimeDto, IHasModificationTimeDto, ISoftDeleteDto, IHasActiveStatusDto
    {
    }
}
