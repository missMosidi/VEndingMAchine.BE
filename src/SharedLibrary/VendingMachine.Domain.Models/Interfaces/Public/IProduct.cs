namespace VendingMachine.Domain.Models.Interfaces.Public
{
    public interface IProduct
    {
        string ProductName { get; set; }

        string? ProductDescription { get; set; }

        decimal ProductPrice { get; set; }


    }
}
