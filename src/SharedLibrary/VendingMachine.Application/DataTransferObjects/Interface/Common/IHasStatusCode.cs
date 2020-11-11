using VendingMachine.Domain.Models.Enums;

namespace VendingMachine.Application.DataTransferObjects.Interface.Common
{
    public interface IHasStatusCode
    {
        StatusCode StatusCode { get; set; }
    }
}
