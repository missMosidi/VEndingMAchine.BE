using VendingMachine.Domain.Models.Interfaces.Common;
using VendingMachine.Domain.Models.Models.Public;
using System.ComponentModel.DataAnnotations;

namespace VendingMachine.Domain.Models.Models.Common
{
    public class StatusBaseEntity<TPrimaryKey> : Entity<TPrimaryKey>, IHasStatus
    {
        [Required]
        public virtual Status Status { get; set; }
    }
}
