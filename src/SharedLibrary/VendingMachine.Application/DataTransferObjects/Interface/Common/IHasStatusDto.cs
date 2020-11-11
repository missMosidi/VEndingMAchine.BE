using VendingMachine.Application.DataTransferObjects.Dtos.Public.Statuses;

namespace VendingMachine.Application.DataTransferObjects.Interface.Common
{
    public interface IHasStatusDto
    {
        StatusDto Status { get; set; }
    }
}
