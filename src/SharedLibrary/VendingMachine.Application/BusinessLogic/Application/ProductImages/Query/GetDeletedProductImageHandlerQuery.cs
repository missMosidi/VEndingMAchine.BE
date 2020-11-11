using AutoMapper;
using VendingMachine.Application.BaseHandler;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.ProductImages;
using VendingMachine.Domain.Models.Models.Public;
using VendingMachine.Persistance.EntityFramework.Context;

namespace VendingMachine.Application.BusinessLogic.Application.ProductImages.Query
{
    public class GetDeletedProductImageHandlerQuery : BaseGetDeletedRequestHandler<ProductImage, DetailedProductImageDto, GetDeletedProductImageDto, VendingMachineDbContext>
    {
        public GetDeletedProductImageHandlerQuery(VendingMachineDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
