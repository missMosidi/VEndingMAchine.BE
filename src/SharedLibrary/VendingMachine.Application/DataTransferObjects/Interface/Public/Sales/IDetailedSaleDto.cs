using RVendingMachine.Application.DataTransferObjects.Interface.Audited;
using VendingMachine.Application.DataTransferObjects.Interface.Common;
using VendingMachine.Domain.Models.Interfaces.Public;

namespace VendingMachine.Application.DataTransferObjects.Interface.Public.Sales
{
    public interface IDetailedSaleDto : ISale, IHasStatusDto, IHasProductDto, IHasCreationTimeDto
    {
    }
}
