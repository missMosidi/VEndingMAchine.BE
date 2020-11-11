using VendingMachine.Domain.Models.Enums;

namespace VendingMachine.Domain.Models.Interfaces.Public
{
    public interface IStatus
    {
        StatusCode StatusCode { get; set; }

        string StatusName { get; set; }

        string StatusDescription { get; set; }
    }
}
