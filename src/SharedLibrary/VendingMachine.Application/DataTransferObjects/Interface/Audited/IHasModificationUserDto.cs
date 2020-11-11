using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RVendingMachine.Application.DataTransferObjects.Interface.Audited
{
    public interface IHasModificationUserDto
    {
        Guid? LastModifierUserId { get; set; }
    }
}
