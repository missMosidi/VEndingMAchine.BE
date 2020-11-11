using VendingMachine.Application.DataTransferObjects.Dtos.Public.ProductImages;

namespace VendingMachine.Application.DataTransferObjects.Interface.Common
{
    public interface IHasProductImageDto
    {
        ProductImageDto ProductImage { get; set; }
    }
}
