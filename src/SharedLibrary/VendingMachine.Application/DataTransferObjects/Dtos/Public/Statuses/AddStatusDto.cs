using System;
using VendingMachine.Application.DataTransferObjects.DataTransferObjects.Interface.Public.Statuses;
using VendingMachine.Domain.Models.Enums;

namespace VendingMachine.Application.DataTransferObjects.Dtos.Public.Statuses
{

    public class AddStatusDto : IAddStatusDto
    {
        public StatusCode StatusCode { get; set; }

        public string StatusName { get; set; }

        public string StatusDescription { get; set; }

        public Guid? CreatorUserId { get; set; }

        public bool ActiveStatus { get; set; }
    }
}
