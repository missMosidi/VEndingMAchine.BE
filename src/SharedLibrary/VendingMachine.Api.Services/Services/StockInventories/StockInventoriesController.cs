using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;
using VendingMachine.Api.Services.BaseControllers;
using VendingMachine.Api.Services.Responses.Commons;
using VendingMachine.Application.DataTransferObjects.Dtos.Public.StockInventories;
using VendingMachine.Domain.Models.Enums;

namespace VendingMachine.Api.Services.Services.StockInventories
{
    [AllowAnonymous]
    public class StockInventoriesController : BaseAsyncFullApiService<AddStockInventoryDto, UpdateStockInventoryDto, DeleteStockInventoryDto, RestoreStockInventoryDto, GetAllStockInventoryDto, GetStockInventoryDto, GetDeletedStockInventoryDto, GetStockInventoryByStatusCodeDto, GetStockInventoryByStatusIdDto, StockInventoryDto, DetailedStockInventoryDto, Guid>,
        IStockInventoriesServices
    {
        public StockInventoriesController(IMediator mediator, InternalServerResponse internalServerResponse) : base(mediator, internalServerResponse)
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

        public override Task<ActionResult> GetDeletedAsync(CancellationToken cancellationToken)
        {
            return base.GetDeletedAsync(cancellationToken);
        }

        public override Task<ActionResult> AddAsync([FromBody] AddStockInventoryDto value, CancellationToken cancellationToken)
        {
            return base.AddAsync(value, cancellationToken);
        }

        public override Task<ActionResult> UpdateAsync(Guid id, [FromBody] UpdateStockInventoryDto value, CancellationToken cancellationToken)
        {
            return base.UpdateAsync(id, value, cancellationToken);
        }

        public override Task<ActionResult> DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            return base.DeleteAsync(id, cancellationToken);
        }

        public override Task<ActionResult> RestoreAsync(Guid id, CancellationToken cancellationToken)
        {
            return base.RestoreAsync(id, cancellationToken);
        }
    }
}
