using AutoMapper;
using VendingMachine.Application.BaseHandler;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.ProductImages;
using VendingMachine.Domain.Models.Models.Public;
using VendingMachine.Persistance.EntityFramework.Context;

namespace VendingMachine.Application.BusinessLogic.Application.ProductImages.Command
{
    public class UpdateProductImageHandlerCommand : BaseUpdateRequestHandler<ProductImage, ProductImageDto, UpdateProductImageDto, VendingMachineDbContext>
    {
        public UpdateProductImageHandlerCommand(VendingMachineDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
