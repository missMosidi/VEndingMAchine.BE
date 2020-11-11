using RVendingMachine.Application.DataTransferObjects.Interface.Audited;

namespace VendingMachine.Application.DataTransferObjects.Interface.Common
{
    public interface IFullAuditedDtoCore : IHasCreationTimeDto, IHasCreationUserDto, IHasModificationUserDto, IHasModificationTimeDto, IHasDeletionUserDto, IHasDeletionTimeDto, ISoftDeleteDto
    {

    }
}
