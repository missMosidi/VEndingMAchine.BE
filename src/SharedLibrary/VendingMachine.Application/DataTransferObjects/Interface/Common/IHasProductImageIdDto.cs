using System;

namespace VendingMachine.Application.DataTransferObjects.Interface.Common
{
    public interface IHasProductImageIdDto
    {
        Guid? ProductImageId { get; set; }
    }
}
