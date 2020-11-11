using System;
using System.ComponentModel.DataAnnotations;
using VendingMachine.Domain.Models.Interfaces.Common;

namespace VendingMachine.Domain.Models.Models.Common
{
    public class FullAuditedEntity<TPrimaryKey> : Entity<TPrimaryKey>, IFullAudited
    {
        [Required]
        public virtual DateTime CreationTime { get; set; }
        public virtual Guid? CreatorUserId { get; set; }
        public virtual Guid? LastModifierUserId { get; set; }
        public virtual DateTime? ModicationTime { get; set; }
        public virtual Guid? DeleterUserId { get; set; }
        public virtual DateTime? DeletionTime { get; set; }
        public virtual bool IsDeleted { get; set; }
    }
}
