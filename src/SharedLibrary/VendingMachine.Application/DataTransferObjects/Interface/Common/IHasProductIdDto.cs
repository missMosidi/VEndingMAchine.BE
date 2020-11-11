using System;

namespace VendingMachine.Application.DataTransferObjects.Interface.Common
{
    public interface IHasProductIdDto
    {
        Guid? ProductId { get; set; }
    }
}
