using System;

namespace VendingMachine.Domain.Models.Interfaces.Audited
{
    public interface IHasModificationUser
    {
        Guid? LastModifierUserId { get; set; }
    }
}
