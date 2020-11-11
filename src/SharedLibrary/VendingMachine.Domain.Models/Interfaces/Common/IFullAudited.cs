using VendingMachine.Domain.Models.Interfaces.Audited;

namespace VendingMachine.Domain.Models.Interfaces.Common
{
    public interface IFullAudited : IHasCreationTime, IHasCreationUser, IHasModificationUser, IHasModificationTime, IHasDeletionUser, IHasDeletionTime, ISoftDelete
    {
    }
}
