using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VendingMachine.Domain.Models.Models.Public;

namespace VendingMachine.Domain.Models.Models.Common
{
    public class StatusBaseFullAuditedEntity<TPrimaryKey> : FullAuditedEntity<TPrimaryKey>
    {
        [Required]
        public virtual Status Status { get; set; }
    }
}

