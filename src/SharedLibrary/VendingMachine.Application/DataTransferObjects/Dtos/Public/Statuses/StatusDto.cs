using VendingMachine.Application.DataTransferObjects.DataTransferObjects.Interface.Public.Statuses;
using VendingMachine.Application.DataTransferObjects.Dtos.Common;
using VendingMachine.Domain.Models.Enums;

namespace VendingMachine.Application.DataTransferObjects.Dtos.Public.Statuses
{

    public class StatusDto : EntityDto<long>, IStatsuDto
    {
        public StatusCode  StatusCode { get; set; }

        public string StatusName { get; set; }

        public string StatusDescription { get; set; }

    }
}
