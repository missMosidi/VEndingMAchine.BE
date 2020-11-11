using System;

namespace VendingMachine.Domain.Models.Interfaces.Audited
{
    public interface IHasCreationTime
    {
        DateTime CreationTime { get; set; }
    }
}
