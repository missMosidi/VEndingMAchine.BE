namespace VendingMachine.Domain.Models.Interfaces.Public
{
    public interface ISale
    {
        int Quantity { get; set; }

        decimal TotalAmount { get; set; }

        decimal Change { get; set;  }

    }
}
