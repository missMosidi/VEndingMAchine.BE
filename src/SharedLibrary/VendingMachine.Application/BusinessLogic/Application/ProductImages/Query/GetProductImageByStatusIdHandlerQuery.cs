using AutoMapper;
using VendingMachine.Application.BaseHandler;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.ProductImages;
using VendingMachine.Domain.Models.Models.Public;
using VendingMachine.Persistance.EntityFramework.Context;

namespace VendingMachine.Application.BusinessLogic.Application.ProductImages.Query
{
    public class GetProductImageByStatusIdHandlerQuery : BaseGetByStatusIDRequestHandler<ProductImage, DetailedProductImageDto, GetProductImageByStatusIdDto, VendingMachineDbContext>
    {
        public GetProductImageByStatusIdHandlerQuery(VendingMachineDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
