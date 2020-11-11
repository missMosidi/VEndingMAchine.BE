using MediatR;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.Statuses;

namespace VendingMachine.Application.DataTransferObjects.DataTransferObjects.Interface.Public.Statuses
{
    public interface IDeleteStatusDto: IRequest<StatusDto>
    {
    }
}
