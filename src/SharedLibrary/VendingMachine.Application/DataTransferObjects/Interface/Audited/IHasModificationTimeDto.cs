using System;
using System.ComponentModel.DataAnnotations;

namespace RVendingMachine.Application.DataTransferObjects.Interface.Audited
{
    public interface IHasModificationTimeDto
    {
        [Required]
        DateTime? ModicationTime { get; set; }
    }
}
