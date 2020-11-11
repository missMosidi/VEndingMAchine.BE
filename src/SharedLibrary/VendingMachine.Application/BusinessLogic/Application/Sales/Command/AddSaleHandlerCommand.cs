using AutoMapper;
using VendingMachine.Application.BaseHandler;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.Sales;
using VendingMachine.Domain.Models.Models.Public;
using VendingMachine.Persistance.EntityFramework.Context;

namespace VendingMachine.Application.BusinessLogic.Application.Sales.Command
{
    public class AddSaleHandlerCommand : BaseAddRequestHandler<Sale, AddSaleDto, VendingMachineDbContext>
    {
        public AddSaleHandlerCommand(VendingMachineDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
