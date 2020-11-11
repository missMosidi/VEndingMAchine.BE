using System;

namespace RVendingMachine.Application.DataTransferObjects.Interface.Audited
{
    public interface IHasCreationTimeDto
    {
        DateTime? CreationTime { get; set; }
    }
}
