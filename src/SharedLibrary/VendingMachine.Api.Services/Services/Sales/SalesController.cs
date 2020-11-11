using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;
using VendingMachine.Api.Services.BaseControllers;
using VendingMachine.Api.Services.Responses.Commons;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.Sales;
using VendingMachine.Domain.Models.Enums;

namespace VendingMachine.Api.Services.Services.Sales
{
    [AllowAnonymous]
    public class SalesController : BaseAsyncCreateReadWithStatusAPIService<AddSaleDto, GetAllSaleDto, GetSaleDto, GetSaleByStatusCodeDto, GetSaleByStatusIdDto, SaleDto, DetailedSaleDto, Guid>,
        ISalesServices
    {
        public SalesController(IMediator mediator, InternalServerResponse internalServerResponse) : base(mediator, internalServerResponse)
        {
        }

        public override Task<ActionResult> GetAllAsync(CancellationToken cancellationToken)
        {
            return base.GetAllAsync(cancellationToken);
        }

        public override Task<ActionResult> GetByIDAsync(Guid id, CancellationToken cancellationToken)
        {
            return base.GetByIDAsync(id, cancellationToken);
        }

        public override Task<ActionResult> GetByStatusCodeAsync(StatusCode statusCode, CancellationToken cancellationToken)
        {
            return base.GetByStatusCodeAsync(statusCode, cancellationToken);
        }

        public override Task<ActionResult> GetByStatusIDAsync(long statusId, CancellationToken cancellationToken)
        {
            return base.GetByStatusIDAsync(statusId, cancellationToken);
        }

        public override Task<ActionResult> AddAsync([FromBody] AddSaleDto value, CancellationToken cancellationToken)
        {
            return base.AddAsync(value, cancellationToken);
        }
    }
}
