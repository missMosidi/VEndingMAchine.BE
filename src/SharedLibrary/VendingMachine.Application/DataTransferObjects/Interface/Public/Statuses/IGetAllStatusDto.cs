using MediatR;
using System.Collections.Generic;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.Statuses;

namespace VendingMachine.Application.DataTransferObjects.DataTransferObjects.Interface.Public.Statuses
{
    public interface IGetAllStatusDto : IRequest<List<StatusDto>>
    {

    }
}
