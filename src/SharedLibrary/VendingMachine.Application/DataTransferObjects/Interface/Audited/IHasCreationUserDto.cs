using System;

namespace RVendingMachine.Application.DataTransferObjects.Interface.Audited
{
    public interface IHasCreationUserDto
    {
        Guid? CreatorUserId { get; set; }
    }
}
