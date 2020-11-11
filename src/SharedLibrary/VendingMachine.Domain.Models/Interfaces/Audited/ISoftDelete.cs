namespace VendingMachine.Domain.Models.Interfaces.Audited
{
    public interface ISoftDelete
    {
        bool IsDeleted { get; set; }
    }
}
