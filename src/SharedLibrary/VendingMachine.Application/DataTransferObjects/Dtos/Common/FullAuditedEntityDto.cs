using VendingMachine.Application.DataTransferObjects.Interface.Common;
using System;

namespace VendingMachine.Application.DataTransferObjects.Dtos.Common
{
    public class FullAuditedEntityDto<TPrimaryKey> : InputBaseEntityDto<TPrimaryKey>, IFullAuditedDtoCore
    {
        public DateTime? CreationTime { get ; set ; }
        public Guid? CreatorUserId { get ; set ; }
        public Guid? LastModifierUserId { get ; set ; }
        public DateTime? ModicationTime { get ; set ; }
        public Guid? DeleterUserId { get ; set ; }
        public DateTime? DeletionTime { get ; set ; }
        public bool IsDeleted { get ; set ; }
    }
}
