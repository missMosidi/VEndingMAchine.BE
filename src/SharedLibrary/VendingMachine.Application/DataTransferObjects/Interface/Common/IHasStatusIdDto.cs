using System;

namespace VendingMachine.Application.DataTransferObjects.Interface.Common
{
    public interface IHasStatusIdDto
    {
        long? StatusId { get; set; }
    }
}
