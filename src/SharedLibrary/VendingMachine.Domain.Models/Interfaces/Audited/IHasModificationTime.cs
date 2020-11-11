using System;

namespace VendingMachine.Domain.Models.Interfaces.Audited
{
    public interface IHasModificationTime
    {
        DateTime? ModicationTime { get; set; }
    }
}
