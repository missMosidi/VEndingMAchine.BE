using VendingMachine.Application.DataTransferObjects.Interface.Public.Statuses;

namespace VendingMachine.Application.DataTransferObjects.Dtos.Public.Statuses
{
    public class GetStatusByActiveStatusDto : IGetStatusByActiveStatusDto
    {
        public bool ActiveStatus { get; set; }
    }
}
