using System;
using VendingMachine.Application.DataTransferObjects.DataTransferObjects.Interface.Public.Statuses;
using VendingMachine.Application.DataTransferObjects.Dtos.Common;
using VendingMachine.Domain.Models.Enums;

namespace VendingMachine.Application.DataTransferObjects.Dtos.Public.Statuses
{

    public class UpdateStatusDto : InputBaseEntityDto<long>, IUpdateStatusDto
    {
        public StatusCode StatusCode { get; set; }

        public string StatusName { get; set; }

        public string StatusDescription { get; set; }

        [System.Text.Json.Serialization.JsonIgnore, Newtonsoft.Json.JsonIgnore]
        public Guid? LastModifierUserId { get; set; }

        public bool ActiveStatus { get; set; }
    }
}
