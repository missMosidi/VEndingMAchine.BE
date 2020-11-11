using MediatR;
using System.Collections.Generic;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.Statuses;

namespace VendingMachine.Application.DataTransferObjects.Interface.Public.Statuses
{
    public interface IGetDeletedStatusDto : IRequest<List<DetailedStatusDto>>
    {
    }
}
