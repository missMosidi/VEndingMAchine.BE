using VendingMachine.Application.DataTransferObjects.DataTransferObjects.Interface.Public.Statuses;
using VendingMachine.Application.DataTransferObjects.Dtos.Common;

namespace VendingMachine.Application.DataTransferObjects.Dtos.Public.Statuses
{
    public class GetStatusDto: InputBaseEntityDto<long>, IGetStatusDto
    {

    }
}
