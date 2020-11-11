using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VendingMachine.Domain.Models.Enums;
using VendingMachine.Domain.Models.Interfaces.Common;
using VendingMachine.Domain.Models.Interfaces.Public;
using VendingMachine.Domain.Models.Models.Common;
using VendingMachine.Domain.Models.Utilities;

namespace VendingMachine.Domain.Models.Models.Public
{
    [Table("Statuses", Schema = FrameWorkSchemas.Public)]
    public class Status : FullAuditedEntity<long>,
        IStatus, IHasActiveStatus
    {
        [Required]
        public virtual StatusCode StatusCode { get; set; }

        [Required, StringLength(FrameWorkStandardEntityRules.ENTITY_SHORT_NAME_LENGHT)]
        public virtual string StatusName { get; set; }

        [StringLength(FrameWorkStandardEntityRules.ENTITY_SHORT_DESCRIPTION_LENGHT)]
        public virtual string StatusDescription { get; set; }

        [Required]
        public virtual bool? ActiveStatus { get; set; }
    }
}
