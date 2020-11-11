using AutoMapper;
using VendingMachine.Application.BaseHandler;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.Products;
using VendingMachine.Domain.Models.Models.Public;
using VendingMachine.Persistance.EntityFramework.Context;

namespace VendingMachine.Application.BusinessLogic.Application.Products.Command
{
    public class RestoreProductHandlerCommand : BaseRestoreRequestHandler<Product, ProductDto, RestoreProductDto, VendingMachineDbContext>
    {
        public RestoreProductHandlerCommand(VendingMachineDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
