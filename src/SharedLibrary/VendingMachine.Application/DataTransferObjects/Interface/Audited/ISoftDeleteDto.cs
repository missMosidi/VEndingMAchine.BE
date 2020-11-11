using System.ComponentModel.DataAnnotations;

namespace RVendingMachine.Application.DataTransferObjects.Interface.Audited
{
    public interface ISoftDeleteDto
    {
        [Required]
        bool IsDeleted { get; set; }
    }
}
