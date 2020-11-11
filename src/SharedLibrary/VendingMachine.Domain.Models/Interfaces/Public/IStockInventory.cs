using VendingMachine.Domain.Models.Interfaces.Common;

namespace VendingMachine.Domain.Models.Interfaces.Public
{
    public interface  IStockInventory
    {
        int TotalItems { get; set; }

        bool IsOutOfStock { get; set; }
    }
}
