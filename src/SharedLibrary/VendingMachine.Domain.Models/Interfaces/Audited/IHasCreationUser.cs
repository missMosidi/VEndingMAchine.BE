using System;

namespace VendingMachine.Domain.Models.Interfaces.Audited
{
    public interface IHasCreationUser
    {
        Guid? CreatorUserId { get; set; }
    }
}
