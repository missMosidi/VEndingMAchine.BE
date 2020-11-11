namespace VendingMachine.Domain.Models.Interfaces.Common
{
    public interface IHasActiveStatus
    {
        bool? ActiveStatus { get; set; }
    }
}
