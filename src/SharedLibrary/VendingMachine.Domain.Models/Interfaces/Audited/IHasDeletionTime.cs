using System;

namespace VendingMachine.Domain.Models.Interfaces.Audited
{
    public interface IHasDeletionTime
    {
        DateTime? DeletionTime { get; set; }
    }
}
