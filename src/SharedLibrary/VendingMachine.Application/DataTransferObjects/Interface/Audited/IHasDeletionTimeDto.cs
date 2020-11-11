using System;

namespace RVendingMachine.Application.DataTransferObjects.Interface.Audited
{
    public interface IHasDeletionTimeDto
    {
        DateTime? DeletionTime { get; set; }
    }
}
