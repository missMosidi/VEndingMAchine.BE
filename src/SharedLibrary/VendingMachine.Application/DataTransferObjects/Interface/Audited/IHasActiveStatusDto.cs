using System.ComponentModel.DataAnnotations;

namespace RVendingMachine.Application.DataTransferObjects.Interface.Audited
{
    public interface IHasActiveStatusDto
    {
        [Required]
        bool ActiveStatus { get; set; }
    }
}
