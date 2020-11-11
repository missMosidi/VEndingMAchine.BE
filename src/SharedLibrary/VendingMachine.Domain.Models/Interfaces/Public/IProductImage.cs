namespace VendingMachine.Domain.Models.Interfaces.Public
{
    public interface IProductImage
    {
        string ImageName { get; set; }

        byte[] ImageData { get; set;}

        string ImageDescription { get; set; }
    }
}
