using VendingMachine.Application.DataTransferObjects.Interface.Public.Statuses;
using System;
using VendingMachine.Application.DataTransferObjects.Dtos.Common;
using VendingMachine.Domain.Models.Enums;

namespace VendingMachine.Application.DataTransferObjects.Dtos.Public.Statuses
{
    public class DetailedStatusDto : EntityDto<long>, IDetialedStatusDto
    {
        public StatusCode StatusCode { get; set; }
        public string StatusName { get; set; }
        public string StatusDescription { get; set; }
        public Guid? CreatorUserId { get; set; }
        public DateTime? CreationTime { get; set; }
        public Guid? LastModifierUserId { get; set; }
        public DateTime? ModicationTime { get; set; }
        public bool IsDeleted { get; set; }
        public bool ActiveStatus { get; set; }
    }
}
