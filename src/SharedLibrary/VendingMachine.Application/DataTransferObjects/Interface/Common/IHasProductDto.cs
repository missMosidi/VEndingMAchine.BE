using VendingMachine.Application.DataTransferObjects.Dtos.Public.Products;

namespace VendingMachine.Application.DataTransferObjects.Interface.Common
{
    public interface IHasProductDto
    {
        ProductDto Product { get; set; }
    }
}
