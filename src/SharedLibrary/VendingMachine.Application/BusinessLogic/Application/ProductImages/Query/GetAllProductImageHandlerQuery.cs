using AutoMapper;
using VendingMachine.Application.BaseHandler;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.ProductImages;
using VendingMachine.Domain.Models.Models.Public;
using VendingMachine.Persistance.EntityFramework.Context;

namespace VendingMachine.Application.BusinessLogic.Application.ProductImages.Query
{
    public class GetAllProductImageHandlerQuery : BaseGetAllRequestHandler<ProductImage, ProductImageDto, GetAllProductImageDto, VendingMachineDbContext>
    {
        public GetAllProductImageHandlerQuery(VendingMachineDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
