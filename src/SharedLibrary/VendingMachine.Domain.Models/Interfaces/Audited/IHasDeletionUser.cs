using System;

namespace VendingMachine.Domain.Models.Interfaces.Audited
{
    public interface IHasDeletionUser
    {
        Guid? DeleterUserId { get; set; }
    }
}
